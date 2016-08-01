using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableThree : MonoBehaviour 
{


	public void LoadLevelThree () 
	{
		SceneManager.LoadScene ("TimesTable3");
	}

	public void LoadMainMenu () 
	{
		SceneManager.LoadScene ("MainMenu");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadLevelThree();
			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "AI")
		{
			LoadMainMenu();
			Destroy (other.gameObject);
		}
	}
}
