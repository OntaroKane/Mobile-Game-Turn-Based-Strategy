using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

public class RegisterScript : MonoBehaviour
{
    public GameObject UsernameRegister;
    public GameObject PasswordRegister;
    public GameObject EmailRegister;
    public GameObject PasswordConfirm;
    private string username;
    private string password;
    private string email;
    private string passwordConf;
    private string form;
    private bool EmailValid = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    public static string getHashSha256(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        SHA256Managed hashstring = new SHA256Managed();
        byte[] hash = hashstring.ComputeHash(bytes);
        string hashString = string.Empty;
        foreach (byte x in hash)
        {
            hashString += String.Format("{0:x2}", x);
        }
        Debug.Log(hashstring.ToString());
        return hashString;
        
    }

public void RegisterButton()
    {
        bool em = false;
        bool ps = false;
        bool cps = false;



        if (email != "")
        {
            if (EmailValid)
            {
                if (email.Contains("@"))
                {
                    if (email.Contains("."))
                    {
                        em = true;
                    }
                    else
                    {
                        Debug.LogWarning("Email is incorect");
                    }
                }
                else
                {
                    Debug.LogWarning("Email is incorect");
                }
            }
            else
            {
                Debug.LogWarning("Email is incorect");
            }
        }
        else
        {
            Debug.LogWarning("Email Field is Empty");
        }
        if (password != "")
        {
            if (password.Length > 5)
            {
                ps = true;
            }
            else
            {
                Debug.LogWarning("Password must be at least 6 characters long");
            }
        }
        else
        {
            Debug.LogWarning("Password field is empty");
        }
        if (passwordConf != "")
        {
            if (passwordConf == password)
            {
                cps = true;
            }
            else
            {
                Debug.LogWarning("Passwords don't match");
            }
        }
        else
        {
            Debug.LogWarning("Password Confirmation Field is empty");
        }
        if (em == true && cps == true && ps == true)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (UsernameRegister.GetComponent<InputField>().isFocused)
            {
                EmailRegister.GetComponent<InputField>().Select();
            }
            if (EmailRegister.GetComponent<InputField>().isFocused)
            {
                PasswordRegister.GetComponent<InputField>().Select();
            }
            if (PasswordRegister.GetComponent<InputField>().isFocused)
            {
                PasswordConfirm.GetComponent<InputField>().Select();
            }
            if (PasswordConfirm.GetComponent<InputField>().isFocused)
            {
                UsernameRegister.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (password != "" && username != "" && email != "" && passwordConf != "")
            {
                RegisterButton();
            }

        }
            username = UsernameRegister.GetComponent<InputField>().text;
            email = EmailRegister.GetComponent<InputField>().text;
            password = PasswordRegister.GetComponent<InputField>().text;
            passwordConf = PasswordConfirm.GetComponent<InputField>().text;
        
    }
}
