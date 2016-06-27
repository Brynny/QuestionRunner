using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	void Start()
	{

	}

	public void LoadNewGame () 
	{
		SceneManager.LoadScene ("CharacterSelect");
	}

	void Highscores () 
	{
		//SceneManager.LoadScene();
	}

	void QuitGame () 
	{
		Application.Quit ();
	}
}
