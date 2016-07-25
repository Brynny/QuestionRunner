using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour 
{

	public void LoadCharacterSelect () 
	{
		SceneManager.LoadScene ("CharacterSelect");
	}
}