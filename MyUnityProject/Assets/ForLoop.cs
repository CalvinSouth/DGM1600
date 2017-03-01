using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

    int myInt = 0;
	
	// Update is called once per frame
	void Update () {
		for(int x = 0; x<=10; x++)
        {
            myInt += 2;
        }
        print(myInt);
	}
}
