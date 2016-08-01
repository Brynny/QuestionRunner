using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadTimesTableFour : MonoBehaviour
{


	public void LoadLevelFour () 
	{
		SceneManager.LoadScene ("TimesTable4");
	}

	public void LoadMainMenu () 
	{
		SceneManager.LoadScene ("MainMenu");
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
			LoadMainMenu();
			Destroy (other.gameObject);
		}
	}
}
