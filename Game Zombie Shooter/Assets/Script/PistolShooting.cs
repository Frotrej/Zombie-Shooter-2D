using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour
{
    [SerializeField]
    int weaponDMG = 3;
    int layerMask = 1 << 8;

    private void Start()
    {
        layerMask = ~layerMask;
    }

    void FixedUpdate()
    {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 10f, layerMask);
         //nie dziala no i tyle
        if (hit)
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            print($"Trafienie: {hit.collider.name}");
        }
        else
        {
            Debug.DrawLine(transform.position, transform.TransformDirection(Vector2.down) * 1000, Color.green);
            print("Brak trafienia");
        }
        print(layerMask);
    }
}
