using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableFour : MonoBehaviour
{


	public void LoadLevelFour () 
	{
		SceneManager.LoadScene ("TimesTable4");
	}

	public void LoadDefeatLevel () 
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelFour();
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "AI")
		{
			LoadDefeatLevel();
			Destroy (other.gameObject);
		}
	}
}
