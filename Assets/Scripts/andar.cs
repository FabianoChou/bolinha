using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class andar : MonoBehaviour
{
    private float moveSpeed = 7;
    public Rigidbody rb;
    public float forcaPulo;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3 (horizontal,0 , vertical);
        transform.position += direction * Time.deltaTime * moveSpeed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Pular();
        }
    }

    void Pular()
    {
        rb.AddForce(Vector2.up * forcaPulo);
    }
   
}
