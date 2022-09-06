using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb2d;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update() {
        // Proccessing Inputs
        ProcessInputs();
    }

    void FixedUpdate() {
        // Physics Calculations
        Move();
    }

    void ProcessInputs() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);

        if(Input.GetKeyDown(KeyCode.W)){
            Debug.Log("W Key had been executed as an Input");
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            Debug.Log("A Key had been executed as an Input");
        }
        else if(Input.GetKeyDown(KeyCode.S)){
            Debug.Log("S Key had been executed as an Input");
        }
        else if(Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("D Key had been executed as an Input");
        }
       
    }

    void Move() {
        rb2d.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
