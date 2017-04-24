using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLose : MonoBehaviour {

    public GameObject endMessage;
    public List<Text> nums = new List<Text>();
    int winCondition = 0;

	// Use this for initialization
	void Start () {
        endMessage.SetActive(false);
	}
	
	private void OnTriggerEnter2D(Collider2D collision)
    {
        for(int x = 0; x <= nums.Count; x++)
        {
            if(nums[x] != null)
            {
                endMessage.SetActive(true);
            }
        }
    }
}
