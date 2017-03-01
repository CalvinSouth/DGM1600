using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoops : MonoBehaviour {

    public List<GameObject> powerUpList;
    public List<GameObject> cubeList;
    public List<GameObject> sphereList;
    public List<GameObject> capsuleList;

    // Use this to check data
    public void CheckData ()
    {
        foreach(GameObject item in powerUpList)
        {
            switch (item.name)
            {
                case "Cube":
                    cubeList.Add(item);
                    break;
                case "Sphere":
                    sphereList.Add(item);
                    break;
                case "Capsule":
                    capsuleList.Add(item);
                    break;
            }
        }


    }
}
