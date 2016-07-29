using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCityLevelTwo : MonoBehaviour
{

	public void LoadCityTwo () 
	{
		SceneManager.LoadScene ("CityLevel2");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadCityTwo();
			Destroy (other.gameObject);
		}
	}
}
