using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCityLevelThree : MonoBehaviour
{

	public void LoadCityThree () 
	{
		SceneManager.LoadScene ("CityLevel3");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadCityThree();
			Destroy (other.gameObject);
		}
	}
}
