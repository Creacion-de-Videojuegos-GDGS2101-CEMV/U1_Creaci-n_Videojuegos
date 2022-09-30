using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Este script se utiliza para que la camará que se establecio siga a nuestro camión de manera correcta.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/
public class CamController : MonoBehaviour



{
    public GameObject auto;
    public Vector3 upCam = new Vector3(0,10,-10);

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
     transform.position = auto.transform.position + upCam;   
    }
}
