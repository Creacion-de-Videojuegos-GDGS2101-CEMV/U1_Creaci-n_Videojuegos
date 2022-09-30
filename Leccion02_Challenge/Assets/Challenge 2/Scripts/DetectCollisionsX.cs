using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Este script se utiliza para destruir las pelotas cuando chocan con el objeto que en este caso es el perro..
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
