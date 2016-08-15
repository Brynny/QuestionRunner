using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	public void LoadNewGame () 
	{
		SceneManager.LoadScene ("CharacterSelect");
	}

	public void Highscores () 
	{
		SceneManager.LoadScene("HighscoreBoard");
	}

	public void QuitGame () 
	{
		Application.Quit ();
	}

	public void Tutorial ()
	{
		SceneManager.LoadScene ("Tutorial");
	}

	public void Credits()
	{
		SceneManager.LoadScene ("Credits");
	}
}
