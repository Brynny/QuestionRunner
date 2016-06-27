using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevelOne : MonoBehaviour 
{
	public void LevelSelect()
	{
		SceneManager.LoadScene("LevelSelect");
	}
}
