using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para para destruir las pelotas dependiendo la posicion en la que se encuentren y que no sobrepasen
el límite izquierdo además tambien destruye las pelotas cuando estas caigan en el perro.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        //Destruye los perros si la posisicion de x es inferior a la posicion al limite de la posicion izquierda
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        //Destruye las pelotas si la posicion es es menor que el limite del boton
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
