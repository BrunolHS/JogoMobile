using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaObjetos : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> MeuObjeto;
    public float meuTempo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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

            GameObject Bosta = Instantiate(MeuObjeto[indicador], novaPos, Quaternion.identity);

            // Destruir Inimigo
            Destroy(Bosta, 3f);
            
            meuTempo = 0;

        }
       
    }
}
