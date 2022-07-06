using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player1;
    private float moveHorizontal;
    private float moveVertical;
    private Vector2 moveDirection;

    private Rigidbody2D playerRigidbody2D;


    private float MVspeed = 2.5f;


    // Update is called once per frame
    void Awake()
    {
        //pobranie komponentu rigidbody2D obiektu
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        //utworzenie Vector2 na podstawie zmiennych moveHorizontal/Vertical
        moveDirection = new Vector2 (moveHorizontal, moveVertical);

        playerRigidbody2D.MovePosition(playerRigidbody2D.position + moveDirection * Time.fixedDeltaTime * MVspeed);
    }





            //przemieszenie uzywane dla obiektow rigidBody2D dynamic - na ktore wplywa grawitacja
            //transform.position += new Vector2(moveHorizontal * MVspeed * Time.fixedDeltaTime, moveVertical * MVspeed * Time.fixedDeltaTime);  
    
}
