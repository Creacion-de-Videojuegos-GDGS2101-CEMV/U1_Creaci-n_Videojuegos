using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para mover el hueso que tenemos.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class MoveBone : MonoBehaviour
{
    public float distancia = 11;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > distancia) {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward*Time.deltaTime*20);   
    }
}
