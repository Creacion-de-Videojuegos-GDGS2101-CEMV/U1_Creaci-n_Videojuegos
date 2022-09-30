using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para generar varios animales de manera randon en cualquier lugar del mapa.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrDogs;
    // Start is called before the first frame update
    void Start()
    {
     InvokeRepeating("createAnimal", 1.5F, 1.5F);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createAnimal(){
        int aleatorio = Random.Range(0, 3);
        int valX = Random.Range(-20, 20);

         Instantiate(arrDogs[aleatorio], 
                new Vector3(valX,
                transform.position.y, 11), 
                arrDogs[0].transform.rotation);
    }
}
