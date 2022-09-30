using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para el la rotación de la hélice del avión que gire de manera adecuada.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class ControllerHelice : MonoBehaviour
{

    //Se crea una variable para la velocidad del giro de la helice
    public float velocidadGiro = 1500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Utilizamos el metodo transform.Rotate, para que así la helice logre dar vueltas en el eje x
        //se toma con la función forward y la multiplicamos por la variable que habíamos asignado ant.
        // que es velocidadGiro
        transform.Rotate(Vector3.forward * velocidadGiro);
    }
}
