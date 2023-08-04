using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Vertical : MonoBehaviour
{
    //Declarando as variáveis
    //------- Variáveis Públicas -------
    //Variável que receberá a velocidade de aceleração
    public float velocidade;

    //------- Variáveis Privadas -------
    //Variável que receberá o deslocamento vertical (y)
    float deslocamentoVertical;

    //Variáveis que limitaram o deslocamento vertical
    float verticalMaximo, verticalMinimo;

    // Start is called before the first frame update
    void Start()
    {
        velocidade = 10f;
        verticalMaximo = 4.40f;
        verticalMinimo = -4.40f;
    }

    // Update is called once per frame
    void Update()
    {
        deslocamentoVertical = Input.GetAxis("Vertical") * velocidade;
        deslocamentoVertical *= Time.deltaTime;

        this.transform.Translate(0f, deslocamentoVertical, 0f);

        if (this.transform.position.y > verticalMaximo)
        {
            this.transform.position = new Vector3(this.transform.position.x, verticalMaximo, this.transform.position.z);
        }
        if (this.transform.position.y < verticalMinimo)
        {
            this.transform.position = new Vector3(this.transform.position.x, verticalMinimo, this.transform.position.z);
        }
    }
}
