using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialWrongAnswer : MonoBehaviour
{
	public Button WrongButton;

	void OnEnable()
	{
		WrongButton.onClick.AddListener(WrongAnswer);
	}

	void WrongAnswer()
	{
		Destroy(transform.parent.gameObject);
	}
}