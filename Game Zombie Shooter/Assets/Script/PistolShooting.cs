using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour
{
    int weaponDMG = 3;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left mouse button pressed...
          // get ray starting at camera position and passing through the mouse pointer:
          //var ray = new Ray2D();        //Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          //var hit = new RaycastHit2D();        //RaycastHit;  allocate variable RaycastHit


            /*if (Physics2D.Raycast(ray, hit))
            { // if something hit...
                print("Clicked on " + hit.transform.name); // print its name
            }
            else
            {
                print("Nothing hit");
            }*/
        }

        

        RaycastHit2D detectRayHit = Physics2D.Raycast(transform.position, transform.forward);
        if (detectRayHit.collider == null) //raycast najprawdopodobniej trafia sam siebie !
        {
            print($"Trafienie: {detectRayHit.transform.name}");
        }
        else
        {
            print("Brak trafienia");
        }
    }
}
