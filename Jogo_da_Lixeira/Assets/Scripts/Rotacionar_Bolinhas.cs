using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Rotacionar_Bolinhas : MonoBehaviour
{
    //-------Variáveis Privadas------
    //Essa variável será usada para definir uma aceleração de rotação
    float aceleracao;
    //Essa variável será do tipo vetor e será usada para rotacionar a bolinha
    Vector3 rotacaoX;

    //Essa variável será usada para chamar o script Controlar_Texto
    Controlar_Textos controlarPontos;

    // Start is called before the first frame update
    void Start()
    {
        aceleracao = 100f;
        rotacaoX = new Vector3(0f, 0f, (aceleracao * Time.deltaTime));
        
        //Inicializar a variável controlarPontos recebendo todas as
        //propriedades e comportamentos do Script Controlar_Textos
        controlarPontos = FindObjectOfType(typeof(Controlar_Textos)) as Controlar_Textos;
    }
    
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotacaoX);

        if (this.transform.position.y < -5.209f)
        {
            controlarPontos.PerderPontos(gameObject.tag);
            Destroy(this.gameObject);
        }
    }

    public void ControlarPontosGanhos(GameObject objeto)
    {
        controlarPontos.GanharPontos(objeto.tag);
        if(objeto.tag != "Untagged")
        {
            Destroy(objeto);
        }
        
    }
}
