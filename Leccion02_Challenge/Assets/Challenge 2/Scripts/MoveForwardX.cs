using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para para mover el objeto de perro por la velocidad y el tiempo..
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
