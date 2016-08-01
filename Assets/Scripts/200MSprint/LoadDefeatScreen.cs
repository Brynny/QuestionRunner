using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadDefeatScreen : MonoBehaviour 
{


	public void LoadMainMenu () 
	{
		SceneManager.LoadScene ("MainMenu");
	}

	void OnTriggerEnter2D (Collider2D other)
	{

	}
}
