using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para mover al granjero de manera adecuada de izquierda a derecha dependiendo de donde saldrán los animales
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject proyectilBone;
    float horInput;
    float limiteMov = 20;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > limiteMov){
            transform.position = new Vector3(limiteMov, 
                transform.position.y, transform.position.z);
        }

        if(transform.position.x < -limiteMov){
            transform.position = new Vector3(-limiteMov, 
                transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(proyectilBone, transform.position,
            proyectilBone.transform.rotation);
        }

        float horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
