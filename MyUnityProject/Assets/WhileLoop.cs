using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        int num = 0;
        bool myBool = true;

        while (myBool)
        {
            ++num;
            if (num == 5)
            {
                myBool = false;
            }
        }
    }
}