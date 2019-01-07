using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float jumpForce = 6.5f;
    public bool isJumping = false;
    public Rigidbody2D JugadorBody;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (isJumping == false) {
                JugadorBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                isJumping = true;

            }
            
        }
    }


    private void OnTriggerEnter2D(Collider2D Colision)
    {
        if (Colision.tag == "Ground")
        {
            Debug.Log("En tierra");
            isJumping = false;
        }

    }
}

