using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isGrounded = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }

    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    [Range(1, 10)]
    public float jumpVelocity;
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true) {
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity; //addForce (siła) zmienione na velocity (prędkość)
        } 
    }
}
