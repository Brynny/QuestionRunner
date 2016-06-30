﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text timerText;
	public Text countdownText;
	float timer;
	float countdown = 5f;

	void Start () 
	{
	
	}
	

	void Update ()
	{
		countdown -= Time.deltaTime;
		int countdownSeconds = Mathf.RoundToInt(countdown);
		countdownText.text = countdownSeconds + " seconds";

		//Start Timer
		if (countdown <= 0)
		{
			Destroy (countdownText);
			timer += Time.deltaTime;
			//Show timer in nearest second
			int seconds = Mathf.RoundToInt(timer);

		//show the Timer
		timerText.text = "Timer: " + seconds + " seconds";
		}
	
	}
}
