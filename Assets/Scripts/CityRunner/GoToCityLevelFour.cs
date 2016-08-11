using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToCityLevelFour : MonoBehaviour
{

	public void LoadCityFour () 
	{
		SceneManager.LoadScene ("CityLevel2");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadCityFour();
		}
	}
}
