using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Generador : MonoBehaviour
{
    public Botones botones;
    public int azar;
    private bool iniciaAzar;
    public GameObject objeto1;
    public GameObject objeto2;
    public GameObject objeto3;
    public GameObject objeto4;
    public GameObject objeto5;
    public GameObject objeto6;
    public GameObject objeto7;
    public GameObject objeto8;
    public GameObject objeto9;
    public GameObject targetblanco;
    public GameObject targetverde;
    public Animator anim;
    public string fase;
    public static bool next;
    public static float contador;
    public static float contador2;
    public static float contadorglobal;
    public static int scorejuego;
    public static float restacontador;
    public static int colortarget;
    public static int Destruirasteroide;
    private GameObject activeObject;

    //public Audio explosion;
    public Material yellow;
    public Material red;
    public Material normal;
    private int colorState = 0;
    public GameObject campo;
    
    public static int rango;
    public static string tiempo;
    public static float speed;
    public static int depth;
    public string Rango { get; set; }
    public string Velocidad { get; set; }
    public string Tiempo { get; set; }
    public string Profundidad { get; set; }

    public TextMeshProUGUI EndMessageText;
    public TextMeshProUGUI WinMessageText;
    public Canvas EndCanvas;
    public Canvas WinCanvas;

    private int win;

    public void RecibirValores(string rango_, string velocidad_, string tiempo_, string profundidad_)
    {
        Rango = rango_;
        Velocidad = velocidad_;
        Tiempo = tiempo_;
        Profundidad = profundidad_;

        rango = int.Parse(rango_);
        speed = float.Parse(velocidad_);
        tiempo = tiempo_;
        depth = int.Parse(profundidad_);

        Debug.Log("Valores recibidos: Rango - " + Rango + ", Velocidad - " + Velocidad + ", Tiempo - " + Tiempo);
    }

    // Start is called before the first frame update
    void Start()
    {
        scorejuego = 0;
        next = false;
        azar = Random.Range(1, 10);
        Debug.Log("PRIMER azar: " + azar);
        iniciaAzar = false;
        colortarget = 2;
        targetblanco.SetActive(true);
        targetverde.SetActive(false);
        Debug.Log("Campo en " + transform.position);
        Debug.Log("Rango: " + rango + "Speed: " + speed);
        //rango = 100;
        //speed = 6;
        //depth = 150;
        contador = 0;

    }

    private void OnTriggerEnter(Collider other)
    {
        colorState++; // Increment color state on collision

        switch (colorState)
        {
            case 1:
                campo.GetComponent<MeshRenderer>().material = yellow;
                break;
            case 2:
                campo.GetComponent<MeshRenderer>().material = red;
                break;
            case 3:
                EndGameLost("Game Over!!!!");
                //GetComponent<MeshRenderer>().material = normal;
                break;
        }
    }

    private void EndGameLost(string message)
    {
        EndCanvas.gameObject.SetActive(true);
        EndMessageText.text = message;
        Invoke("LoadLevelsSceneLost", 3f);
    }

    private void EndGameWin(string message)
    {
        WinCanvas.gameObject.SetActive(true);
        WinMessageText.text = message;
        Invoke("LoadLevelsSceneWin", 3f);
    }

    private void LoadLevelsSceneLost()
    {
        SceneManager.LoadScene("Levels");
    }
    
    private void LoadLevelsSceneWin()
    {
        SceneManager.LoadScene("Levels");
    }

    // Update is called once per frame
    void Update()
    {
        contadorglobal += Time.deltaTime;

        if (colortarget == 1)
        {
            targetblanco.SetActive(false);
            targetverde.SetActive(true);
        }

        if (colortarget == 2)
        {
            targetblanco.SetActive(true);
            targetverde.SetActive(false);
        }



        if (azar == 1)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto1, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;
        }


        if (azar == 2)

        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto2, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            //ParaAsteroide2.asteroide2 = 1;
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (azar == 3)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto3, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            //ParaAsteroide3.asteroide3 = 1;
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }


        if (azar == 4)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto4, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            //ParaBasura4.basura4 = 1;
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (azar == 5)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto5, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (azar == 6)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto6, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (azar == 7)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto7, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;
        }

        if (azar == 8)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto8, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (azar == 9)
        {
            colortarget = 2;
            var positionRand = new Vector3(Random.Range(-rango, rango), Random.Range(-rango * 0.6f, rango * 0.4f), depth);
            activeObject = Instantiate(objeto9, positionRand, Quaternion.identity);
            activeObject.SetActive(true);
            ParaAsteroide.asteroide1 = 1;
            azar = 0;

        }

        if (next == true)
        {
            Destroy(activeObject);
            Debug.Log("Next: " + next);
            azar = Random.Range(1, 10);
            Debug.Log("numero azar: " + azar);
            next = false;
            win++;
        }

        if(win == 10)
        {
            EndGameWin("YOU WIN!!!!!");
        }

    }
}
