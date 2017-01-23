using UnityEngine;

public class changeColor : MonoBehaviour {
	void Update() {
		if(Input.GetKeyDown(KeyCode.R))
			GetComponent<Renderer>().material.color = Color.red;
	}
}