using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadVictory : MonoBehaviour 
{

	public void LoadVictoryLevel () 
	{
		SceneManager.LoadScene ("Victory");
	}

	public void LoadDefeatLevel()
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadVictoryLevel();
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
		}
	}
}
