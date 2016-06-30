using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionGenerator : MonoBehaviour 
{
	public Transform spawnPoint;
	public GameObject[] questions;
	GameObject questionSpawned;
	public bool questionAvailable;

	float timer = 5f;

	void Update () 
	{
		//Start Timer
		timer -= Time.deltaTime;
		//Show timer in nearest second
		int seconds = Mathf.RoundToInt(timer);

		if (questionSpawned == null && timer <= 0)
		{
			SpawnQuestions();
			timer = 0;
		}

	}

	public void SpawnQuestions()
	{
		int questionIndex = Random.Range (0, questions.Length);
		questionSpawned = Instantiate (questions[questionIndex], spawnPoint.position, Quaternion.identity) as GameObject;
		questionSpawned.transform.parent = GameObject.Find("Canvas").transform;
	}
}
