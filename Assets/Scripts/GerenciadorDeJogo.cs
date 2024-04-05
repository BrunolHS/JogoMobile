using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeJogo : MonoBehaviour
{

    public bool jogoON = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }



    public void IniciarJogo()
    {
        jogoON = true;
    }

    public bool EstadoDoJogo()
    {
        return jogoON;
    }



}
