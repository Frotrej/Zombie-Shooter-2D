using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject player1;
    private float moveHorizontal;
    private float moveVertical;

    private float MVspeed = 0.2f;


    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal != 0 || moveVertical != 0)
        {
            transform.position += new Vector3(moveHorizontal * MVspeed * Time.fixedDeltaTime, moveVertical * MVspeed * Time.fixedDeltaTime, 0);
        }
        
    }
}
