using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class CountdownTimer : MonoBehaviour
{
	int currentTime = 0;
	int startingTime = 120;

	public Text countdownText;

	void Start()
	{
		currentTime = startingTime;
		countDownTimer();
	}

	void Update()
	{
		TimeSpan spanTime = TimeSpan.FromSeconds(startingTime);

		if (spanTime.TotalSeconds <= 6)
		{
			SoundManagerScript.PlaySound("Alarm");
			countdownText.color = Color.red;
		}

		if (spanTime.TotalSeconds <= 0)
		{
			currentTime = 0;
			SceneManager.LoadScene(2);
		}
	}

	void countDownTimer()
	{
		if (startingTime > 0)
		{
			TimeSpan spanTime = TimeSpan.FromSeconds(startingTime);

			countdownText.text = " " + spanTime.Minutes + " : " + spanTime.Seconds;
			startingTime--;
			Invoke("countDownTimer", 1.0f);
		}

	}
}


/// Old countdown timer
/// It will not convert 120F to 2 minutes.

/*
private void Update()
{
	//main timer counter

	//currentTime -= 1 * Time.deltaTime;
	currentTime -= Time.deltaTime;
	countdownText.text = currentTime.ToString("F");

	//Changes the color of the timer text to red when it reaches 5 and sound an alarm

	if (currentTime <= 5)
	{
		SoundManagerScript.PlaySound("Alarm");
		countdownText.color = Color.red;
	}

	if (currentTime <= 0)
	{
		currentTime = 0;
		SceneManager.LoadScene(2);
	}
}*/





