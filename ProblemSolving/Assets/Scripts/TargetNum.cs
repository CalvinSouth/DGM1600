using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetNum : MonoBehaviour {

    public static System.Random random = new System.Random(); // Random object, allows random number to be called on startup
    public int num = random.Next(0, 20), score = 0; // Sets num to a random number between 0 and 19. // Tracks score, starts at 0
    public Text target, scoreText; // Contains the target text field and score text field
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
            target.transform.position = new Vector2(target.transform.position.x, 580); // Resets position of target
            num = random.Next(0,20); // Gives num a new value
            target.text = num.ToString(); // Displays new value in game
            score += 1; // Updates score
            scoreText.text = "Score: " + score; // Updates score text
        }
    }
}
