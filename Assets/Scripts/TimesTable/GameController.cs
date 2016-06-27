using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	public Text timerText;
	float timer;

	void Start () 
	{
	
	}
	

	void Update ()
	{
		//Start Timer
		timer += Time.deltaTime;
		//Show timer in nearest second
		int seconds = Mathf.RoundToInt(timer);

		//show the Timer
		timerText.text = "Timer: " + seconds + " seconds";
	
	}
}
