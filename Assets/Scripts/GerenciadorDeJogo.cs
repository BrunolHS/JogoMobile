using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Morreu()
    {
        Reiniciar();
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }

}
