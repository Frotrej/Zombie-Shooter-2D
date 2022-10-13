using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player1;
    private float moveX;
    private float moveY;
    

    private Rigidbody2D playerRigidbody2D;
    public Animator animator;


    private float MVspeed = 2.5f;


    
    void Awake()
    {
        //pobranie komponentu rigidbody2D obiektu
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        //utworzenie Vector2 na podstawie zmiennych moveHorizontal/Vertical
        Vector2 moveDirection = new Vector2 (moveX, moveY);

        playerRigidbody2D.MovePosition(playerRigidbody2D.position + moveDirection * Time.fixedDeltaTime * MVspeed);

        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);

        Vector2 moveDirectionNormalized = moveDirection.normalized;
        animator.SetFloat("SPEED", moveDirectionNormalized.magnitude);

    }





            //przemieszenie uzywane dla obiektow rigidBody2D dynamic - na ktore wplywa grawitacja
            //transform.position += new Vector2(moveHorizontal * MVspeed * Time.fixedDeltaTime, moveVertical * MVspeed * Time.fixedDeltaTime);  
    
}
