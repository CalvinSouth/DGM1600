using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {

    public Text endMessageText;
    public GameObject endMessage;
    public List<Text> nums = new List<Text>();
    int winCondition = 0;

	// Use this for initialization
	void Start () {
        endMessage.SetActive(false);
	}

    private void Update()
    {
        if (nums.Any())
        {
            
        }
    }
	
    // Code runs if a number enters the deadLine
	private void OnTriggerEnter2D(Collider2D collision)
    {
        for(int x = 0; x <= nums.Count; x++) // Checks if the list has any values
        {
            if(nums[x] != null)
            {
                endMessageText.text = "Game Over!";
                endMessage.SetActive(true);
            }
        }
    }
}
