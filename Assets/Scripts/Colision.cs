using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Vermelho":
                Destroy(collision.gameObject);
                break;
            case "Azul":
                rb.AddForce(Vector3.back * 700);
                break;
            case "Verde":
                print("Colidiu com obstaculo verde");
                break;
        }
    }
   

}
