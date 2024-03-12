using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFundo : MonoBehaviour
{
    public GameObject irmao;
    public float meuTempo;
    public float ajuste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meuTempo += Time.deltaTime;
        
        //avança pelo tempo
        if (meuTempo > 0.0001f)
        {
            transform.position = transform.position + new Vector3(0,-0.01f, 0);
            meuTempo = 0;
        }
        //mudaposição
        if(transform.position.y < -14)
        {
            transform.position = new Vector3(0, irmao.transform.position.y + 43, 0);
        }     
    }
}
