using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public int x = 0;
    public int[] myArray = { 0, 1, 2, 3, 4 };

    // Update is called once per frame
    void Update()
    {
        if(myArray[x] == 3)
        {
            print("It is 3");
        }
        else
        {
            x++;
        }
    }
}