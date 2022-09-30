using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para el segumiento del avión con respecto de la cámara en este caso irá enfocando
siempre al avión para que el usuario tenga mejor control.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    //Esta la variable Vector 3 que se adjunto al objeto avion y lo inciamos con los valores correspondientes.
    private Vector3 offset = new Vector3(20,2,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //A traves del metodo transform se agrega al objeto plane que es el avion mas el desplazamiento
        transform.position = plane.transform.position + offset;
    }
}
