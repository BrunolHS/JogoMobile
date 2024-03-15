using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAviao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
    }

    void Movimentar()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 posMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            //caso queira mover em X e Y
            Vector3 posPersonagem = new Vector3 (posMouse.x, posMouse.y, transform.position.z);
            
            //caso queira mover apenas em X
            //Vector3 posPersonagem = new Vector3(posMouse.x, transform.position.y, transform.position.z);
            
            transform.position = Vector3.MoveTowards(transform.position, posPersonagem, 0.5f);
        }

    }
}
