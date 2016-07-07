using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour 
{


	public void LoadSameLevel () 
	{
		SceneManager.LoadScene ("TimesTable");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadSameLevel();
			Destroy (other.gameObject);
		}
	}
}
