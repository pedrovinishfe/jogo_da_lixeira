using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Mouse : MonoBehaviour
{
    //Declarando as variáveis
    //------- Variáveis Públicas -------
    //Variável que receberá a velocidade de aceleração
    public float velocidade;

    //------- Variáveis Privadas -------
    //Variável que receberá o deslocamento horizontal (x)
    float deslocamentoHorizontal;

    //Variáveis que limitaram o deslocamento horizontal
    float horizontalMaximo, horizontalMinimo;

    //Essa variável receberá a posição atual no eixo horizontal (X)
    float posicaoAtualX;

    //Variável que receberá o Transform do objeto para movimenta-lo
    Transform trtLixeira;

    //Essa variável usada para chamar o Script Rotacionar_Bolinhas
    Rotacionar_Bolinhas pontosGanhos;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10f;
        horizontalMaximo = 8.439265f;
        horizontalMinimo = -8.439265f;

        trtLixeira = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Essa variável receberá o deslocamento horizontal do Mouse(Esquerda = (-1,0), Parado = 0 e Direita = (0,1))
        deslocamentoHorizontal = Input.GetAxisRaw("Mouse X") * velocidade;
        deslocamentoHorizontal *= Time.deltaTime;
        posicaoAtualX = this.transform.position.x;

        this.transform.Translate(deslocamentoHorizontal, 0f, 0f);

        if (this.transform.position.x > horizontalMaximo)
        {
            this.transform.position = new Vector3(horizontalMaximo, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x < horizontalMinimo)
        {
            this.transform.position = new Vector3(horizontalMinimo, this.transform.position.y, this.transform.position.z);
        }

        trtLixeira.position += (Vector3.right * deslocamentoHorizontal);
    }
}
