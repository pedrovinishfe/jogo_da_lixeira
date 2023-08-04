using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Adiciona automaticamente um Rigidbody2D ao Objeto
[RequireComponent(typeof(Rigidbody2D))]
public class Mover_Lixeira : MonoBehaviour
{
    //Declarando as vari�veis
    //------Vari�veis Privadas-----
    //Criar uma vari�vel que receber� o deslocamento no eixo horizontal (X)
    float deslocamentoHorizontal;

    //Vari�veis P�blicas
    //Criar uma vari�vel p�blica que receber� a velocidade de acelera��o
    public float velocidade;

    //Cria uma vari�vel do tipo Vector 2d para deslocar o objeto
    Vector2 deslocamento = Vector2.zero;

    //Cri auma vari�vel Rigidbody2D para deslocar o objeto pelo seu Rigidbody
    Rigidbody2D rbLixeira;

    //Essa vari�vel usada para chamar o Script Rotacionar_Bolinhas
    Rotacionar_Bolinhas pontosGanhos;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 15f;
        rbLixeira = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoHorizontal = Input.GetAxisRaw("Horizontal");
        deslocamento = new Vector2(deslocamentoHorizontal, 0f);
    }

    void FixedUpdate()
    {
        rbLixeira.MovePosition(rbLixeira.position + deslocamento * (Time.deltaTime * velocidade));
    }

    //Detecta colis�es de objetos com Colliders
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Inicializa a vari�vel pontosGanhos recebendo todas as funcionalidades do script Rotacionar_Bolinhas
        pontosGanhos = FindObjectOfType(typeof(Rotacionar_Bolinhas)) as Rotacionar_Bolinhas;
        pontosGanhos.ControlarPontosGanhos(collision.gameObject);
    }
}
