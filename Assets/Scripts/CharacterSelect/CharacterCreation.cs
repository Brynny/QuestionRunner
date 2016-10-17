using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour 
{

	private GameObject[] characterList;
	private int index;

	private void Start()
	{
		index = PlayerPrefs.GetInt("CharacterSelected");

		characterList = new GameObject[transform.childCount];

		// fill array with character models
		for (int i = 0; i <transform.childCount; i++)
		{
			characterList[i] = transform.GetChild(i).gameObject;
		}

		// toggle off their renderer
		foreach (GameObject go in characterList)
		{
			go.SetActive(false);
		}

		// toggle on selected character
		if (characterList[index])
		{
			characterList[index].SetActive(true);
		}

	}

	public void ToggleLeft()
	{
		// Toggle off current model
		characterList[index].SetActive(false);

		index--; 
		if(index < 0)
			index = characterList.Length - 1;

		//Toggle on current model
		characterList[index].SetActive(true);
	}

	public void ToggleRight()
	{
		// Toggle off current model
		characterList[index].SetActive(false);

		index++; 
		if(index == characterList.Length)
			index = 0;

		//Toggle on current model
		characterList[index].SetActive(true);
	}

	public void StartGame()
	{
		PlayerPrefs.SetInt("CharacterSelected", index);
		SceneManager.LoadScene("LevelSelect");
	}







}


