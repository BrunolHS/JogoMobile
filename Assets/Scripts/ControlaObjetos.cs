using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Obstaculo;

    public GameObject Obstaculo2;

    public GameObject Dinheiro;

    public List<GameObject> MeuObjeto;
   
    public float meuTempo = 0;

    private GerenciadorDeJogo GJ;

    

    // Start is called before the first frame update
    void Start()
    {
        GJ = GameObject.FindGameObjectWithTag("GameController").GetComponent<GerenciadorDeJogo>();      
    }

    // Update is called once per frame
    void Update()
    {

        if (GJ.EstadoDoJogo() == true)
        {
            Temporizador();
            CriarObjetos();
        }

    }

    void Temporizador()
    {
        meuTempo += Time.deltaTime;
        
        if(meuTempo > 3)
        {
            meuTempo = 0;

            float chance = Random.Range(0, 5);
            if(chance <= 5)
            {
                CriaObstaculo();
            }
            else
            {
                CriaDinheiro();
            }

            
            
        }
    }

    void CriaObstaculo()
    {

        float posX = Random.Range(-2.5f, 2.5f);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject MeuObstaculo = Instantiate(Obstaculo, posInicial, Quaternion.identity);
        Destroy(MeuObstaculo, 3f);

    }

    void CriaDinheiro()
    {

        float posX = Random.Range(-2.5f, 2.5f);
        Vector3 posInicial = new Vector3(posX, 6, 0);
        GameObject MeuDinheiro = Instantiate(Dinheiro, posInicial, Quaternion.identity);
        Destroy(MeuDinheiro, 3f);

    }


    void CriarObjetos()
    {
        
        meuTempo += Time.deltaTime;
        if(meuTempo > 0.7f) 
        
        {
            //definir valor X
            float valX = Random.Range(-1.7f, 1.7f);

            //posicao
            Vector3 novaPos = new Vector3(valX,7.0f, 0f);

            ///sorteador
            
            int indicador = Random.Range(0, MeuObjeto.Count);

           GameObject MeuObstaculo = Instantiate(MeuObjeto[indicador], novaPos, Quaternion.identity);

            // Destruir Obstaculo
            Destroy(MeuObstaculo, 3f);
            
            meuTempo = 0;

        }

    }

}
