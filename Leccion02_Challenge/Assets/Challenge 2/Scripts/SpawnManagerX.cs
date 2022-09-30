using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para generar las pelotas que sean necesaria y de manera random para el buen
funcionamiento del juego.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //Se cambia a 4.5 el intervalo para generar la pelota ya que decía en el reto que se modificará.
    //private float spawnInterval = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Utilizamos la funcion Invoke y se le pasa el parametro que nos genera las pelotas
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //Se agrega una variable de tipo entero para generar las pelotas y se agrega el metodo random.
        int pelota = Random.Range(0,3);
        //Generación de la pelota en un lugar random de la posición establecida.
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instanciamiento de la bola que aparezca en lugares random de la ubicación.
        Instantiate(ballPrefabs[pelota], spawnPos, ballPrefabs[pelota].transform.rotation);

        //Se modifica la variable startDelay para que el comienzo de la siguiente pelota sea aleatorio
        startDelay = Random.Range(1, 5);
        //llamamos a la funcion con recursividad
        Invoke("SpawnRandomBall", startDelay);
    }

}
