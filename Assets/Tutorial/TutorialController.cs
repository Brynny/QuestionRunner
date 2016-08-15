using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialController : MonoBehaviour 
{
	public void Load200MSprintTutorial()
	{
		SceneManager.LoadScene ("Tutorial200M");
	}

	public void LoadCityRunnerTutorial()
	{
		SceneManager.LoadScene ("TutorialCityRunner");
	}
}
