using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Functions : MonoBehaviour {

    public string userName;
    public InputField myInputField;

    public void UpdateUserName()
    {
        WelcomeUser(myInputField.text);
    }

    void WelcomeUser (string _name)
    {
        userName = _name;
        print("Welcome " + _name + ", get ready to play!");
    }

}
