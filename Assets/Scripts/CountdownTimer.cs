using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
	float currentTime = 0f;
	float startingTime = 120f; //this is for 2 minutes

	public Text countdownText;

	void Start()
	{
		currentTime = startingTime;
	}

	private void Update()
	{
		//main timer counter
		
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString("0");

		if (currentTime <= 0)
		{		
			currentTime = 0;
		}

		//Changes the color of the timer text to red when it reaches 5 and sound an alarm

		if (currentTime <= 5)
		{
			soundManagerScript.PlaySound("Alarm");
			countdownText.color = Color.red;
		}

		if (currentTime <= 0)
		{
			SceneManager.LoadScene(2);
		}
	}
	
}
