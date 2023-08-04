using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criar_Bolinhas_Vetor : MonoBehaviour
{
    //Declarando as vari�veis
    //------Vari�veis P�blicas-----
    //Esse vetor receber� os Prefabs das bolinhas
    public GameObject[] bolinhas = new GameObject[3];
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
        //M�todo usado para criar as bolinhas
        //Assinatura: (Nome do m�todo, tempo de espera para
        //come�ar a criar as bolinha (2 segundos) e frequ�ncia
        //de repeti��o (1 segundo))
        InvokeRepeating("CriarBolinha", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CriarBolinha()
    {
        posicaoX = Random.Range(-8.5f, 8.5f);
        posicaoY = Random.Range(5.5f, 8.0f);
        escolha = Random.Range(0, 3);
        
        //Instancia a bola de papel
        criarBolinha = Instantiate(bolinhas[escolha]);
        //Determina em que posi��o a bolinha ser� criada
        criarBolinha.transform.position = new Vector2(posicaoX, posicaoY);
    }
}
