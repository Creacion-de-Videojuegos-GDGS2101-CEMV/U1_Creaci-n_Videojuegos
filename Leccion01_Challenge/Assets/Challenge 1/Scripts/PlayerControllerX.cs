using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Este script se utiliza para el movimiento correcto del jugador en este caso irá enfocado en los
movimientos del avión que se presenta en el juego.
Miranda Valtierra Carlos Eduardo
28/Septiembre/2022
*/

public class PlayerControllerX : MonoBehaviour
{
    //Se declara la variable de entrada para la velocidad.
    public float speed;
    //Se declara la variable de entrada para la velocidad de la rotación.
    public float rotationSpeed;
    //Se declara la variable de entrada para la rotacion con las flechas de nuestro teclado.
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Se capta la entrada de las flechas del usuario en esta manera que seran verticalmente
        // con la clase input y con el metodo GetAxis 
        verticalInput = Input.GetAxis("Vertical");

        // Se usa para mover el avión de manera constante con componente transform utilizando el Vector3
        // por la variable velocidad y lo multiplicamos por el tiempo con Time.deltaTime
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Control de inclinación del avión arriba/abajo basado con las flechas
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
