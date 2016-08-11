using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	public void LoadNewGame () 
	{
		SceneManager.LoadScene ("CharacterSelect");
	}

	void Highscores () 
	{
		//SceneManager.LoadScene();
	}

	public void QuitGame () 
	{
		Application.Quit ();
	}

	public void Tutorial ()
	{
		SceneManager.LoadScene ("Tutorial");
	}
}
