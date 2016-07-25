using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialCorrectAnswer : MonoBehaviour 
{
	public Button CorrectButton;

	void OnEnable()
	{
		CorrectButton.onClick.AddListener(CorrectAnswer);
	}

	void CorrectAnswer()
	{
		Destroy(transform.parent.gameObject);
	}
}
