using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectHighscoreBoardMode : MonoBehaviour
{
	public void HighscoreBoardLevel()
	{
		SceneManager.LoadScene("HighscoreLevelOne");
	}
}
