using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetNum : MonoBehaviour {

    public static System.Random random = new System.Random(); // Random object, allows random number to be called on startup
    public int? num = random.Next(0, 10); // Sets num to a random number between 0 and 9. 
                                          // Contains a nullable int ("int?"), so as to remove the number from gameplay

    public Text target; // Contains the target text field and victory/loss messages
    public InputField output; // Allows code to read the output field

    // Use this for initialization
    void Start () {
        target.text = num.ToString(); // Displays num in Unity
    }
	
    // Checks the value of output
	void Update()
    {
        if (num == int.Parse(output.text)) // Checks if num is equal to the output field
        {
            num = null; // Removes num from gameplay
            target.text = "";
        }
    }
}
