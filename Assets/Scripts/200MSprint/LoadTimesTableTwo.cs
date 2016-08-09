using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableTwo : MonoBehaviour 
{


	public void LoadLevelTwo () 
	{
		SceneManager.LoadScene ("TimesTable2");
	}

	public void LoadDefeatLevel () 
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelTwo();
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
		}
	}
}
