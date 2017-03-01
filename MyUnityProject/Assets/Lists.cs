using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

    public List<int> mylist = new List<int>();
    public int x = 1;

    void Start()
    {
        mylist.Add(0);
        mylist.Add(3);
        mylist.Add(2);
    }
	
	// Update is called once per frame
	void Update () {
        x *= 2;
        mylist.Add(x);
        print(mylist.Count);
	}
}
