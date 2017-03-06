using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

    public string owner = "Bob";
    private string renter = "Kate";

    private void Awake()
    {
        string cat = "Joe";
        if(cat == "Joe")
        {
            string mouse = "Helen";
            print(cat + " ate " + mouse);
        }
        print(renter);
        print(cat);
        print(owner);
    }

	void Start () {
        string cat = "Frank";
        print(cat);
        print(owner);
	}
}
