using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Head_Raycast : MonoBehaviour
{
    public AudioSource explosion;
    public Botones botones;
    private static int tiempoEspera;

    public string Rango { get; set; }
    public string Velocidad { get; set; }
    public string Tiempo { get; set; }

    public void RecibirValores(string rango_, string velocidad_, string tiempo_)
    {
        Rango = rango_;
        Velocidad = velocidad_;
        Tiempo = tiempo_;

        tiempoEspera = int.Parse(tiempo_);

        // Puedes hacer lo que necesites con estos valores aqu� mismo
        Debug.Log("Valores recibidos: " + tiempoEspera);
    }

    void Start()
    {
        explosion = GetComponent<AudioSource>();
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * 100f);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.green);
            Debug.Log("HE CHOCADO CON UN ASTEROIDE");
            Generador.contador += Time.deltaTime;
            Generador.colortarget = 1;
            GameObject objetoADestruir = hit.transform.gameObject;
            if(Generador.contador > tiempoEspera)
            {
                StartCoroutine(DestroyDespuesDeTiempo(objetoADestruir));
            }
        }
        else
        {
            Generador.contador = 0;
            Generador.colortarget = 2;
        }
    }
    IEnumerator DestroyDespuesDeTiempo(GameObject objeto)
    {
        explosion.Play();
        Generador.next = true;
        yield return 1;
    }
}
