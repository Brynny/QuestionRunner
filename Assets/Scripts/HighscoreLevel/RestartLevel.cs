﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{

	void Update () 
	{
		if (Input.GetKey (KeyCode.R)) 
		{
			SceneManager.LoadScene ("HighscoreLevelOne");
		}
			
	}
}
