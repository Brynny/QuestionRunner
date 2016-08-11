using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableFive : MonoBehaviour
{
	public void LoadLevelFive () 
	{
		SceneManager.LoadScene ("TimesTable5");
	}

	public void LoadDefeatLevel () 
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelFive();
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
		}
	}
}
