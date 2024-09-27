using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D rigidbody2D;
    private Vector2 moveInput;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
      
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical"); 
    }

    void FixedUpdate()
    {

        rigidbody2D.MovePosition(rigidbody2D.position + moveInput * speed * Time.fixedDeltaTime);
    }
}

