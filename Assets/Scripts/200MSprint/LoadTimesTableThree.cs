﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableThree : MonoBehaviour 
{


	public void LoadLevelThree () 
	{
		SceneManager.LoadScene ("TimesTable3");
	}

	public void LoadDefeatLevel () 
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelThree();
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
		}
	}
}
