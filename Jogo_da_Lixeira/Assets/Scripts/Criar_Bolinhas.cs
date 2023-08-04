using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Criar_Bolinhas : MonoBehaviour
{
    //Declarando as variáveis
    //------Variáveis Públicas-----
    //Essas variáveis receberam os Prefabs das bolinhas
    public GameObject bolaJornal, bolaCaderno, bolaSulfite;
    //Tempo entre a criação das bolinhas
    public float tempo;

    //------Variáveis Privadas-------
    //Essa variável receberá uma instância da bolinha de papel que
    GameObject criarBolinha;
    //Quantidade de bolinhas a ser criadas
    int numeroBolas;
    //Controle do laço de repetição While
    int controle;
    //Posição onde a bolinha deverá ser criada no eixo x e eixo y
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
        //Define uma posição aleatória  em X para a criação da bolinha de papel 
       posicaoX = Random.Range(-8.5f, 8.5f);
        // Define uma posição aleatória em Y para a criação da bolinha de papel
        posicaoY = Random.Range(5.5f, 8f);
        //Sorteia qual bolinha será criada
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
        //Instancia a bola de papel e determina em que posição a bola será criada
        criarBolinha.transform.position = new Vector2(posicaoX, posicaoY);
    }
}

