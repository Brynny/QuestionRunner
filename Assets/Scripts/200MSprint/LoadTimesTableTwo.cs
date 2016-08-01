﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableTwo : MonoBehaviour 
{


	public void LoadLevelTwo () 
	{
		SceneManager.LoadScene ("TimesTable2");
	}

	public void LoadMainMenu () 
	{
		SceneManager.LoadScene ("MainMenu");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelTwo();
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "AI")
		{
			LoadMainMenu();
			Destroy (other.gameObject);
		}
	}
}