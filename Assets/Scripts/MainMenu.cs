using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{	 
	public void PlayGame()
	{		
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);		
	}

	public void QuitGame()
	{
		//this is to emphasize that the game quit aside from making a line code Application.Quit()
		SceneManager.LoadScene("Credits", LoadSceneMode.Single);
	}

	public void RetryGame()
	{
		SceneManager.LoadScene("Main", LoadSceneMode.Single);		
	}
}

