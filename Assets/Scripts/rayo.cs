using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayo : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("PRUEBA RAYO");
        if (collision.collider.tag.Equals("asteroide"))
        {
            Debug.Log("ESTOY CHOCANDO CON EL ASTEROIDE");
            Generador.contador += Time.deltaTime;
            Generador.colortarget = 1;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("NO ESTOY COLISIONANDO");
        Generador.contador = 0;
        Generador.colortarget = 2;
    }


}

