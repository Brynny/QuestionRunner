using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public Text timerText;
	public Text countdownText;
	float timer;
	float countdown = 5f;

	//CityRUnnerOnlyVariables
	float incorrectAnswers = 5f;
	public Text incorreectAnswerText;

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

	void FixedUpdate()
	{
		//Track Incorrect Answer
			incorreectAnswerText.text = "Incorrect Answers Left: " + incorrectAnswers;
			WrongAnswerTracker();
	}

	public void WrongAnswer()
	{
		incorrectAnswers = incorrectAnswers - 1f;
	}

	public void WrongAnswerTracker()
	{
		if (incorrectAnswers <= 0)
		{
			SceneManager.LoadScene("Defeat");
		}
	}

}
