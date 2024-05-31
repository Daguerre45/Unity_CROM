using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score1 : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI tiempotext;
    public TextMeshProUGUI velocidadtext;
    int tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text =  " BASURA DESTRUIDA: " + Generador.scorejuego.ToString();
        
        tiempotext.text = " Tiempo: " + Generador.contadorglobal.ToString("0") + " segundos";
        velocidadtext.text = "Velocidad: " + Generador.speed.ToString();
    }
}
