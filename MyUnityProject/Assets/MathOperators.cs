using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

    public int addition = 12 + 4;
    public int subtraction = 12 - 4;
    public float division = 5f / 2f;
    public int multiplication = 10 * 2;
    public int remainder = 7 % 2;

	// Use this for initialization
	void Start () {
        addition += 9; //Add 9 to the equation in "addition"
        subtraction -= 9;
        addition += 3;
        addition = 1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
