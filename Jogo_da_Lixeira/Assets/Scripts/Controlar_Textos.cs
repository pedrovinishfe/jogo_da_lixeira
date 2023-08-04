using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class Controlar_Textos : MonoBehaviour
{
    //Declarando as variáveis
    //-------Variáveis Públicas------
    //Essa variável receberá o objeto tmpCronometro
    public TMP_Text txtCronometro;

    //Essa variável receberá o objeto tmpPontosGanhos
    public TMP_Text txtPontosGanhos;

    //Essa variável receberá o objeto tmpPontosPerdidos
    public TMP_Text txtPontosPerdidos;

    //-------Variáveis Privadas-------
    //Essas variáveis serão usadas para marcar o tempo
    float fltDuracao = 0f;
    float fltHora = 0f;
    float fltMinuto = 0f;
    float fltSegundo = 0f;
    //Essas variáveis serão usadas para controlar os pontos ganhos e perdidos
    int pontosGanhos, pontosPerdidos = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fltDuracao += Time.deltaTime;
        fltSegundo = (fltDuracao % 60);
        fltMinuto = (fltDuracao / 60) % 60;
        fltHora = (fltDuracao / 3600) % 24;
        //Informa o tempo de jogo pelo relógio de tempo real
        //txtCronometro.text = fltDuracao.ToString();

        txtCronometro.text = ((int)fltHora).ToString("00") + ":" + ((int)fltMinuto).ToString("00") + ":" + ((int)fltSegundo).ToString("00");
    }
    //Método que controla os Pontos Ganhos
    public void GanharPontos(string tagID)
    {
        print("Tag ganhar pontos: " + tagID);

       switch(tagID)
        {
            case "Jornal":
                pontosGanhos += 3;
                break;
            
            case "Caderno":
                pontosGanhos += 2;
                break;

            case "Sulfite":
                pontosGanhos += 1;
                break;
        }
        txtPontosGanhos.text = "Pontos ganhos: " + pontosGanhos.ToString();
    }
    //Método que controla os Pontos Perdidos
    public void PerderPontos(string tagID)
    {
        print("Tag perder pontos: " + tagID);

        switch (tagID)
        {
            case "Jornal":
                pontosPerdidos += 3;
                break;
                
            case "Caderno":
                pontosPerdidos += 2;
                break;

            case "Sulfite":
                pontosPerdidos += 1;
                break;
        }
        txtPontosPerdidos.text = "Pontos perdidos: " + pontosPerdidos.ToString();
    }
}

