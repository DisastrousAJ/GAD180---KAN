using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
	float currentTime = 0f;
	float startingTime = 120f;

	[SerializeField] Text countdownText;

	private void Start()
	{
		currentTime = startingTime;
	}

	private void Update()
	{
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString("0");



		if (currentTime <= 0)
		{
			currentTime = 0;
		}

		//Changes the color of the timer text to red when it reaches 10
		if (currentTime <= 10)
		{
			countdownText.color = Color.red;
		}

		if (currentTime <= 0)
		{
			SceneManager.LoadScene(2);
;		}

	}

}
