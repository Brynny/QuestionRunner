using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeedUp : MonoBehaviour 
{
	public Button speedUpButton;

//	void OnEnable()
//	{
//		//speedUpButton.onClick.AddListener(IncreaseSpeed);
//	}

	void IncreaseSpeed()
	{
		GetComponent<playerMovement>().SpeedUp();
	}
}
