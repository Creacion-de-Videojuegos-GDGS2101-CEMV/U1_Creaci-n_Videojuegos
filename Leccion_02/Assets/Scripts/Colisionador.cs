using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*
Este script se utiliza para destruir los animales que salen al momento de chocar con el hueso que tenemos establecido.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
        {
            Destroy(gameObject);
        }
}
