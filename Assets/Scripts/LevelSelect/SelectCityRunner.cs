using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectCityRunner : MonoBehaviour 
{
	public void CityLevel()
	{
		SceneManager.LoadScene("CityLevel1");
	}
}
