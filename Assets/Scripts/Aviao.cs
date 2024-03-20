using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{

    public int vida = 5;
    public int dinheiro = 0;
    private GerenciadorDeJogo GJ;

    // Start is called before the first frame update
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDeJogo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "obstaculo")
        {
            Destroy(colisao.gameObject);
            vida--;
            if (vida <= 0)
            {
                GJ.Morreu();
            }
        }


        if (colisao.gameObject.tag == "dinheiro")
        {
            Destroy(colisao.gameObject);
            dinheiro++;
        }
    }

}
