using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {

    public string[] animals;

    public string animal = "Wolf";
    // Use this for initialization
	void Start () {
        foreach(string animalList in animals)
        {
            if(animal == animalList)
            {
                print("I have a match, it is " + animalList);
            }
            else
            {
                print(animalList + " is not a match");
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
