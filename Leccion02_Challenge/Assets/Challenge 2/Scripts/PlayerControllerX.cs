using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para para lanzar a los perros desde la posición del jugador que en este caso es el granjero.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class PlayerControllerX : MonoBehaviour
{
    //Variable del objeto perro
    public GameObject dogPrefab;

    //Se declara una variable para que se tarde un momento en lanzar un perro
    private float cooldown = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //Condicional para que lanze un perro desde que utiliza el espacio en el teclado
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        
            cooldown = 1;
        }
        if(cooldown >= 0) {
            cooldown -=  Time.deltaTime;
        }
    }
}
