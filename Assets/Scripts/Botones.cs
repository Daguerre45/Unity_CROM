using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;

public class Botones : MonoBehaviour
{
    public DatabaseAcces databaseAccess;
    public Generador generador;
    public Head_Raycast head_Raycast;

    public TMP_InputField  nameRegister;
    public TMP_InputField  surnameRegister;
    public TMP_InputField  ageRegister;
    public TMP_InputField  emailRegister;

    public TMP_InputField  range;
    public TMP_InputField  speed;
    public TMP_InputField  time;
    public TMP_InputField  depth;

   
    public TMP_InputField  passwordRegister;
    public TMP_InputField  passwordLogin;
    public TMP_InputField  emailLogin;
    public Canvas errorCanvas;
    public TextMeshProUGUI errorMessageText;
   
    private string Login = "Login";
    private string Register = "Register";
    private string start = "Start";
    private string Juego_1 = "JUEGO PRINCIPAL 2";
    private string levels = "Levels";
    private string Juego_2 = "GAME_2";
    private string juego_3 = "GAME_3";
    private string pre_level_1 = "Pre_Level_1";
    private string pre_level_2 = "Pre_Level_2";
    private string pre_level_3 = "Pre_Level_3";

    void Start() 
    {
        databaseAccess = FindObjectOfType<DatabaseAcces>();
        generador = FindObjectOfType<Generador>();
        head_Raycast = FindObjectOfType<Head_Raycast>();
    }
    public void OnClickBotonLogin()
    {
        SceneManager.LoadScene(Login);
    }
    public void OnClickBotonRegister()
    {
        SceneManager.LoadScene(Register);
    }
    public void OnClickBotonBackLogin()
    {
        SceneManager.LoadScene(start);
    }
    public void OnClickBotonBackRegister()
    {
        SceneManager.LoadScene(Login);
    }
    public async void OnClickBotonSendLogin()
    {
        string email = emailLogin.text;
        string password = passwordLogin.text;

        // Verificar si existe un usuario con el correo electrónico y contraseña proporcionados
        bool userExists = await databaseAccess.IsUserRegisteredAsync(email, password);

        if (userExists)
        {
            // Si existe un usuario con esos datos, cambiar a la escena correspondiente
            SceneManager.LoadScene("levels");
        }
        else
        {
            // Si no existe, mostrar un mensaje de error
            ShowErrorMessage("No hay ningún usuario registrado con ese email o contraseña.");
        }
    }
    public void OnClickBotonSendRegister()
    {
        RegisterUserAsync(); 
    }
    public void OnClickBotonLevel1()
    {
        SceneManager.LoadScene(pre_level_1);
    }
    public void OnClickBotonLevel2()
    {
        SceneManager.LoadScene(pre_level_2);
    }
    public void OnClickBotonLevel3()
    {
        SceneManager.LoadScene(pre_level_3);
    }
    public void OnClickBotonJugarLevel1()
    {
        string rango = range.text;
        string velocidad = speed.text;
        string tiempo = time.text;
        string profundidad = depth.text;

        generador.RecibirValores(rango, velocidad, tiempo, profundidad);
        head_Raycast.RecibirValores(rango, velocidad, tiempo);

        Debug.Log(rango + " " + velocidad + " " + tiempo);

        if (!IsNumeric(rango) || !IsNumeric(velocidad) || !IsNumeric(tiempo) || !IsNumeric(profundidad))
        {
            ShowErrorMessage("Solo puede haber NÚMEROS en los campos tanto de range, speed y time");
            return;
        }

        SceneManager.LoadScene(Juego_1);
    }
    public void OnClickBotonJugarLevel2()
    {
        string rango = range.text;
        string velocidad = speed.text;
        string tiempo = time.text;
        string profundidad = depth.text;

        generador.RecibirValores(rango, velocidad, tiempo, profundidad);
        head_Raycast.RecibirValores(rango, velocidad, tiempo);

        Debug.Log(rango + " " + velocidad + " " + tiempo);

        if (!IsNumeric(rango) || !IsNumeric(velocidad) || !IsNumeric(tiempo) || !IsNumeric(profundidad))
        {
            ShowErrorMessage("Solo puede haber NÚMEROS en los campos tanto de range, speed y time");
            return;
        }

        SceneManager.LoadScene(Juego_2);
    }
    public void OnClickBotonJugarLevel3()
    {
        string rango = range.text;
        string velocidad = speed.text;
        string tiempo = time.text;
        string profundidad = depth.text;

        generador.RecibirValores(rango, velocidad, tiempo, profundidad);
        head_Raycast.RecibirValores(rango, velocidad, tiempo);

        Debug.Log(rango + " " + velocidad + " " + tiempo);

        if (!IsNumeric(rango) || !IsNumeric(velocidad) || !IsNumeric(tiempo) || !IsNumeric(profundidad))
        {
            ShowErrorMessage("Solo puede haber NÚMEROS en los campos tanto de range, speed y time");
            return;
        }

        SceneManager.LoadScene(juego_3);
    }
    public async void RegisterUserAsync()
    {
        string name = nameRegister.text;
        string surname = surnameRegister.text;
        string age = ageRegister.text;
        string email = emailRegister.text;
        string password = passwordRegister.text;
        int range = 100;
        int speed = 6;
        int time = 1;

        bool validName = IsNameValid(name);
        bool validSurname = IsNameValid(surname);
        bool validAge = IsAgeValid(age);
        bool validEmail = IsEmailValid(email);
        bool validPassword = IsPasswordValid(password);

        if (validName && validSurname && validAge && validEmail && validPassword)
        {
            bool emailRegistered = await databaseAccess.IsEmailRegisteredAsync(email);
            if (!emailRegistered)
            {
                // Si el correo electrónico no está registrado, guardar los datos del usuario
                databaseAccess.SaveDataToDataBase(name, surname, age, email, password, range, speed, time);
                SceneManager.LoadScene("Login");
            }
            else
            {
                // Mostrar mensaje de error si el correo electrónico ya está registrado
                ShowErrorMessage("El correo electrónico ya está registrado.");
            }
    }
        else if(!validName)
        {
            ShowErrorMessage("En el campo de NAME solo puede haber letras y NO puede estar vacío");
        }
        else if(!validSurname)
        {
            ShowErrorMessage("En el campo de SURNAME solo puede haber letras y NO puede estar vacío");
        }
        else if(!validAge)
        {
            ShowErrorMessage("En el campo de AGE solo puede haber números y como máximo 2 y NO puede estar vacío");
        }
        else if(!validEmail)
        {
            ShowErrorMessage("En el campo de EMAL tiene que contener un @ y su .com/.es/...");
        }
        else if(!validPassword)
        {
            ShowErrorMessage("El campo PASSWORD tiene que tener como mínimo 4 caracteres");
        }
    }

    private bool IsNameValid(string name)
    {
        return !string.IsNullOrEmpty(name) && !ContainsNumbers(name);
    }

    private bool IsAgeValid(string age)
    {
        int parsedAge;
        return !string.IsNullOrEmpty(age) && int.TryParse(age, out parsedAge) && age.Length <= 2;
    }

    private bool IsEmailValid(string email)
    {
        return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
    }

    private bool IsPasswordValid(string password)
    {
        return !string.IsNullOrEmpty(password) && password.Length >= 4;
    }
    private bool ContainsNumbers(string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
            return true;
            }
        }
        return false;
    }
    bool IsNumeric(string input)
    {
        // Método para verificar si una cadena contiene solo números
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
    private void ShowErrorMessage(string message)
    {
        errorCanvas.gameObject.SetActive(true);
        errorMessageText.text = message;
    }

    public void HideErrorMessage()
    {
        errorCanvas.gameObject.SetActive(false);
    }

}
