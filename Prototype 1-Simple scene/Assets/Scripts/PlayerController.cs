using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed;

    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //Metodo para mover al jugador con las teclas hacia la dercha o la izquierda
     horizontalInput = Input.GetAxis("Horizontal");
     forwardInput = Input.GetAxis("Vertical");
     //We'll move the vehicle forward
     //transform.Translate(0,0,1);   
     transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
     //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
     transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
