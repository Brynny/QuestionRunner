using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableSix : MonoBehaviour 
{
	public void LoadLevelSix () 
	{
		SceneManager.LoadScene ("TimesTable6");
	}

	public void LoadDefeatLevel () 
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelSix();
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
		}
	}
}
