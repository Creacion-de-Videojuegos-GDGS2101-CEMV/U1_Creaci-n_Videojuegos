using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Este script se utiliza para para mover el objeto de que en este caso es nuestro camión de manera adecuada 
por la carretera con las flechas de mando.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class PlayerController : MonoBehaviour
{

    private float avanza;

    public float velGiro = 20;

    private float girar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float avanza = Input.GetAxis("Vertical"); 
        float gira = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*20*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}
