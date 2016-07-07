using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour 

{
	public void LoadMainMenu()
	{
		SceneManager.LoadScene ("MainMenu");
	}
}