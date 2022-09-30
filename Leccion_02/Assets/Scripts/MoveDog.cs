using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para destruir las pelotas cuando chocan con el objeto que en este caso es el perro..
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class MoveDog : MonoBehaviour
{
    // Start is called before the first frame update

    float limite = 30;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -limite){
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward*Time.deltaTime*15);

    }
}
