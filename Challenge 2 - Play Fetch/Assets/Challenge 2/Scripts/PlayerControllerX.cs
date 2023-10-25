using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float tiemEsp= 1;
    private float tiemDisparo = 0;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiemDisparo)
        {
            tiemDisparo = Time.time + tiemEsp;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
