using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    public GameObject UsernameLogin;
    public GameObject PasswordLogin;
    public GameObject EmailLogin;
    private string username;
    private string password;
    private string email;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoginButton() {
        bool em = false;
        bool ps = false;
        bool user = false;

        if (username != "")
        {
            if (username.Length > 7 && username.Length < 20)
            {
                user = true;
            }
            else
            {
                Debug.LogWarning("Username is not the right length");
            }
        }

        if (email != "")
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
        if (user == true && em == true && ps == true)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (UsernameLogin.GetComponent<InputField>().isFocused)
            {
                EmailLogin.GetComponent<InputField>().Select();
            }
            if (EmailLogin.GetComponent<InputField>().isFocused)
            {
                PasswordLogin.GetComponent<InputField>().Select();
            }
            
            if (PasswordLogin.GetComponent<InputField>().isFocused)
            {
                UsernameLogin.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (password != "" && username != "" && email != "")
            {
                LoginButton();
            }

        }
        username = UsernameLogin.GetComponent<InputField>().text;
        email = EmailLogin.GetComponent<InputField>().text;
        password = PasswordLogin.GetComponent<InputField>().text;
    }
}
