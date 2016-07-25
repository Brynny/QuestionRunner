using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialQuestionGenerator : MonoBehaviour
{
	public Transform spawnPoint;
	public GameObject[] questions;
	GameObject questionSpawned;

	void Start ()
	{
	
	}

	void Update () 
	{
		if (questionSpawned == null) 
		{
			SpawnQuestions ();
		}
	}

	public void SpawnQuestions()
	{
		int questionIndex = Random.Range (0, questions.Length);
		questionSpawned = Instantiate (questions[questionIndex], spawnPoint.position, Quaternion.identity) as GameObject;
		questionSpawned.transform.parent = GameObject.Find("Canvas").transform;
	}
}
