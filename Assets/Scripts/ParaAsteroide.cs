using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ParaAsteroide : MonoBehaviour
{
    private Vector3 camara;
    public static int asteroide1;
    public GameObject objeto;
    public Transform target;
    public float distance;
    void Start()
    {
        Generador.contador2 = 0;
        distance = 1000;
    }

    void Update()
    {
        float step = Generador.speed * Time.deltaTime * 2;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        distance = Vector3.Distance(transform.position, target.position);


        if (distance < 5) // Hace mas lento al acercarse al campo
        {
            step = step / 2;
        }

        if (transform.position.z < 6)
        {
            Debug.Log("LLEGUE AL CAMPO");

            if (asteroide1 == 1)
            {
                Generador.next = true;
                Debug.Log("Entro a next =" + Generador.next);
                asteroide1 = 0;
            }
        }
    }

}
