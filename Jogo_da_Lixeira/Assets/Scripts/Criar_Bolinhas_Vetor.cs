using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criar_Bolinhas_Vetor : MonoBehaviour
{
    //Declarando as variáveis
    //------Variáveis Públicas-----
    //Esse vetor receberá os Prefabs das bolinhas
    public GameObject[] bolinhas = new GameObject[3];
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
        //Método usado para criar as bolinhas
        //Assinatura: (Nome do método, tempo de espera para
        //começar a criar as bolinha (2 segundos) e frequência
        //de repetição (1 segundo))
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
        //Determina em que posição a bolinha será criada
        criarBolinha.transform.position = new Vector2(posicaoX, posicaoY);
    }
}
