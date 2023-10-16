using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volar : MonoBehaviour
{
    private float speed = 7; //Añade la velocidad a la que ira el avion
    private float turnSpeed = 90; // Añade la velocidad de giro que desees.

    private float horizontalInput;
    private float verticalInput; // Agrega el eje vertical.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); // Lee la entrada vertical.

        // Mueve el objeto hacia adelante .
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Gira el objeto alrededor de su eje horizontal.
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
