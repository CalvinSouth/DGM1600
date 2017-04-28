using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {

    public Text endMessage; // Allows access to Text object

	// Use this for initialization
	void Start () {
        endMessage.gameObject.SetActive(false);
	}
	
    // Code runs if a number enters the deadLine
	private void OnTriggerEnter2D(Collider2D collision)
    {
        endMessage.text = "Game Over!";
        endMessage.gameObject.SetActive(true);
    }
}
