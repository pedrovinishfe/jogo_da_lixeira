using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Criar_Bolinhas : MonoBehaviour
{
    //Declarando as vari�veis
    //------Vari�veis P�blicas-----
    //Essas vari�veis receberam os Prefabs das bolinhas
    public GameObject bolaJornal, bolaCaderno, bolaSulfite;
    //Tempo entre a cria��o das bolinhas
    public float tempo;

    //------Vari�veis Privadas-------
    //Essa vari�vel receber� uma inst�ncia da bolinha de papel que
    GameObject criarBolinha;
    //Quantidade de bolinhas a ser criadas
    int numeroBolas;
    //Controle do la�o de repeti��o While
    int controle;
    //Posi��o onde a bolinha dever� ser criada no eixo x e eixo y
    float posicaoX, posicaoY;
    //Escolher bolinha
    int escolha;

    // Start is called before the first frame update
    void Start()
    {
        tempo = 1f;
        numeroBolas = 10;
        //Executa uma Corrotina
        StartCoroutine(Esperar(tempo));
    }

    // Update is called once per frame
    void Update()
    {
    }
    //Executa a corrotina " Esperar" uma quantidade de vez definida
    /*IEnumerator Esperar(float aguardar)
    {
        while (controle <= numeroBolas) 
        {
            CriarBolinhas();
            yield return new WaitForSeconds(aguardar);
            controle++;

        }
    }*/
    //Executa a corrotina"Esperar" indefinidamente
    IEnumerator Esperar(float aguardar)
    {
        while (true)
        {
            CriarBolinhas();
            yield return new WaitForSeconds(aguardar);
            

        }
    }
    public void CriarBolinhas()
    {
        //Define uma posi��o aleat�ria  em X para a cria��o da bolinha de papel 
       posicaoX = Random.Range(-8.5f, 8.5f);
        // Define uma posi��o aleat�ria em Y para a cria��o da bolinha de papel
        posicaoY = Random.Range(5.5f, 8f);
        //Sorteia qual bolinha ser� criada
        escolha = Random.Range(0, 3);

        if(escolha == 0)
        {
            criarBolinha = Instantiate(bolaJornal);
        }else if (escolha == 1)
        {
            criarBolinha = Instantiate(bolaCaderno);
        }else
        {
            criarBolinha = Instantiate(bolaSulfite);
        }
        //Instancia a bola de papel e determina em que posi��o a bola ser� criada
        criarBolinha.transform.position = new Vector2(posicaoX, posicaoY);
    }
}

