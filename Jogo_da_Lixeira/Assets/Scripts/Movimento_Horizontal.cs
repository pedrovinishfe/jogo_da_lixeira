using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimento_Horizontal : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10f;
        horizontalMaximo = 8.439265f;
        horizontalMinimo = -8.439265f;
    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoHorizontal = Input.GetAxis("Horizontal") * velocidade;
        deslocamentoHorizontal *= Time.deltaTime;

        this.transform.Translate(deslocamentoHorizontal, 0f, 0f);

        if (this.transform.position.x > horizontalMaximo)
        {
            this.transform.position = new Vector3(horizontalMaximo, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x < horizontalMinimo)
        {
            this.transform.position = new Vector3(horizontalMinimo, this.transform.position.y, this.transform.position.z);
        }
    }
}
