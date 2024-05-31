using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Teclado : MonoBehaviour
{
    public GameObject keyboardsEmail;
    public GameObject keyboardsPass;
    public GameObject keyboardsName;
    public GameObject keyboardsSurName;
    public GameObject keyboardsAge;
    public GameObject keyboardRange;
    public GameObject keyboardSpeed;
    public GameObject keyboardTime;
    public GameObject keyboardDepth;

    public TMP_InputField emailLogin;
    public TMP_InputField passLogin;
    public TMP_InputField emailRegister;
    public TMP_InputField passRegister;
    public TMP_InputField nameRegister;
    public TMP_InputField surNameRegister;
    public TMP_InputField ageRegister;
    public TMP_InputField range;
    public TMP_InputField speed;
    public TMP_InputField time;
    public TMP_InputField depth;

    private bool selectEmailLogin;
    private bool selectPasswordLogin;
    private bool selectEmailRegister;
    private bool selectPasswordRegister;
    private bool selectNameRegister;
    private bool selectSurNameRegister;
    private bool selectAgeRegister;
    private bool selectRange;
    private bool selectSpeed;
    private bool selectTime;
    private bool selectDepth;

    void Start()
    {
        selectEmailLogin = false;
        selectPasswordLogin = false;

        selectEmailRegister = false;
        selectPasswordRegister = false;
        selectNameRegister = false;
        selectSurNameRegister = false;
        selectAgeRegister = false;

        selectRange = false;
        selectSpeed = false;
        selectTime = false;
        selectDepth = false;

        emailLogin = GetComponentInChildren<TMP_InputField>();
        passLogin = GetComponentInChildren<TMP_InputField>();

        emailRegister = GetComponentInChildren<TMP_InputField>();
        passRegister = GetComponentInChildren<TMP_InputField>();
        nameRegister = GetComponentInChildren<TMP_InputField>();
        surNameRegister = GetComponentInChildren<TMP_InputField>();
        ageRegister = GetComponentInChildren<TMP_InputField>();

        range = GetComponentInChildren<TMP_InputField>();
        speed = GetComponentInChildren<TMP_InputField>();
        time = GetComponentInChildren<TMP_InputField>();
        depth = GetComponentInChildren<TMP_InputField> ();


        keyboardsEmail.SetActive(false);
        keyboardsPass.SetActive(false);
        keyboardsName.SetActive(false);
        keyboardsSurName.SetActive(false);
        keyboardsAge.SetActive(false);

        keyboardRange.SetActive(false);
        keyboardSpeed.SetActive(false);
        keyboardTime.SetActive(false);
        keyboardDepth.SetActive(false);
    }

    private void OnEnable()
    {
        emailLogin.onSelect.AddListener(OnInputFieldEmailSelected);
        passLogin.onSelect.AddListener(OnInputFieldPassSelected);

        emailRegister.onSelect.AddListener(OnInputFielEmailRegisterSelected);
        passRegister.onSelect.AddListener(OnInputFieldPassgisterSelected);
        nameRegister.onSelect.AddListener(OnInputFieldNameSelected);
        surNameRegister.onSelect.AddListener(OnInputFieldSurNameSelected);
        ageRegister.onSelect.AddListener(OnInputFieldRegisterSelected);

        range.onSelect.AddListener(OnInputFieldRangeSelected);
        speed.onSelect.AddListener(OnInputFieldSpeedSelected);
        time.onSelect.AddListener(OnInputFieldTimeSelected);
        depth.onSelect.AddListener(OnInputFieldDepthSelected);
    }

    private void OnInputFieldEmailSelected(string text)
    {
        selectEmailLogin = true;
        selectPasswordLogin = false;
        if (selectEmailLogin)
        {
            keyboardsEmail.SetActive(true);
            keyboardsPass.SetActive(false);
        }
    }
    private void OnInputFieldPassSelected(string text)
    {
        selectEmailLogin = false;
        selectPasswordLogin = true;
        if (selectPasswordLogin)
        {
            keyboardsEmail.SetActive(false);
            keyboardsPass.SetActive(true);
        }
    }

    private void OnInputFielEmailRegisterSelected(string text)
    {
        selectEmailRegister = true;
        selectPasswordRegister = false;
        selectNameRegister = false;
        selectSurNameRegister = false;
        selectAgeRegister = false;

        if (selectEmailRegister)
        {
            keyboardsEmail.SetActive(true);
            keyboardsPass.SetActive(false);
            keyboardsName.SetActive(false);
            keyboardsSurName.SetActive(false);
            keyboardsAge.SetActive(false);
        }
    }
    private void OnInputFieldPassgisterSelected(string text)
    {
        selectEmailRegister = false;
        selectPasswordRegister = true;
        selectNameRegister = false;
        selectSurNameRegister = false;
        selectAgeRegister = false;

        if (selectPasswordRegister)
        {
            keyboardsEmail.SetActive(false);
            keyboardsPass.SetActive(true);
            keyboardsName.SetActive(false);
            keyboardsSurName.SetActive(false);
            keyboardsAge.SetActive(false);
        }
    }
    private void OnInputFieldNameSelected(string text)
    {
        selectEmailRegister = false;
        selectPasswordRegister = false;
        selectNameRegister = true;
        selectSurNameRegister = false;
        selectAgeRegister = false;

        if (selectNameRegister)
        {
            keyboardsEmail.SetActive(false);
            keyboardsPass.SetActive(false);
            keyboardsName.SetActive(true);
            keyboardsSurName.SetActive(false);
            keyboardsAge.SetActive(false);
        }
    }
    private void OnInputFieldSurNameSelected(string text)
    {
        selectEmailRegister = false;
        selectPasswordRegister = false;
        selectNameRegister = false;
        selectSurNameRegister = true;
        selectAgeRegister = false;

        if (selectSurNameRegister)
        {
            keyboardsEmail.SetActive(false);
            keyboardsPass.SetActive(false);
            keyboardsName.SetActive(false);
            keyboardsSurName.SetActive(true);
            keyboardsAge.SetActive(false);
        }
    }
    private void OnInputFieldRegisterSelected(string text)
    {
        selectEmailRegister = false;
        selectPasswordRegister = false;
        selectNameRegister = false;
        selectSurNameRegister = false;
        selectAgeRegister = true;

        if (selectAgeRegister)
        {
            keyboardsEmail.SetActive(false);
            keyboardsPass.SetActive(false);
            keyboardsName.SetActive(false);
            keyboardsSurName.SetActive(false);
            keyboardsAge.SetActive(true);
        }
    }
    private void OnInputFieldRangeSelected(string text)
    {
        selectRange = true;
        selectSpeed = false;
        selectTime = false;
        selectDepth = false;
        if (selectRange)
        {
            keyboardRange.SetActive(true);
            keyboardSpeed.SetActive(false);
            keyboardTime.SetActive(false);
            keyboardDepth.SetActive(false);
        }
    }
    private void OnInputFieldSpeedSelected(string text)
    {
        selectRange = false;
        selectSpeed = true;
        selectTime = false;
        selectDepth = false;
        if (selectSpeed)
        {
            keyboardRange.SetActive(false);
            keyboardSpeed.SetActive(true);
            keyboardTime.SetActive(false);
            keyboardDepth.SetActive(false);
        }
    }
    private void OnInputFieldTimeSelected(string text)
    {
        selectRange = false;
        selectSpeed = false;
        selectTime = true;
        selectDepth = false;
        if (selectTime)
        {
            keyboardRange.SetActive(false);
            keyboardSpeed.SetActive(false);
            keyboardTime.SetActive(true);
            keyboardDepth.SetActive(false);
        }
    }
    private void OnInputFieldDepthSelected(string text)
    {
        selectRange = false;
        selectSpeed = false;
        selectTime = false;
        selectDepth = true;

        if (selectDepth)
        {
            keyboardRange.SetActive(false);
            keyboardSpeed.SetActive(false);
            keyboardTime.SetActive(false);
            keyboardDepth.SetActive(true);
        }
    }
}
