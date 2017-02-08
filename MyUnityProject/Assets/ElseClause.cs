using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElseClause : MonoBehaviour
{

    public string password;
    public bool userAgreement;

    // Use this for initialization
    void Start()
    {
        if (password == "OU812" && userAgreement)
        {
            print("Correct");
        }
        else
        { print("Incorrect"); }
    }

    // Update is called once per frame
    void Update()
    {

    }
}