using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolShooting : MonoBehaviour
{
    [SerializeField]
    int weaponDMG = 3; // zmienna tymczasowa nalezy stworzyc plik z lista obrazen broni
    [SerializeField]
    float weaponCoolDown = 0.4f;
    float timeToNextFire = 0;

    int layerMask = 1 << 8; //ustawienie zmiennej na warstwe Player

    private void Start()
    {
        layerMask = ~layerMask; //inwersja zmiennej, aby raycast ignorowa³ tylko warstwe gracza
    }

    void FixedUpdate()
    {
        
        if (Time.time > timeToNextFire)
        {
            timeToNextFire = Time.time + weaponCoolDown;    //dodanie opoznienia broni do czasu natepnego strzalu


            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 10f, layerMask);
            if (hit)
                {
                    Debug.DrawLine(transform.position, hit.point, Color.red);
                    //print($"Trafienie: {hit.collider.name}");     //pokaz nazwe trafionego obiektu

                    CheckTargetLayer(hit);//
                }
                else
                {
                    Vector2 shotEnd = (transform.position);
                    shotEnd = shotEnd.normalized;

                    //iluzja rysowania lini prostej przez mnozenie drugiego punktu *1000
                    Debug.DrawLine(transform.position, shotEnd * 15, Color.magenta);

                    //print("Brak trafienia");
                }
        }
    }

    void CheckTargetLayer(RaycastHit2D targetInfo)
    {
        if (targetInfo.collider.gameObject.CompareTag("EntityEnemy"))
        {
            //print("to przeciwnik");
            targetInfo.collider.gameObject.SendMessage("DealDMG", weaponDMG);
        }
    }

    void empty()
    {
        float time = Time.time;
    }
}
