using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlowDown : MonoBehaviour
{
	public Button speedUpButton;

	void OnEnable()
	{
		speedUpButton.onClick.AddListener(DecreaseSpeed);
	}

	void DecreaseSpeed()
	{
		GetComponent<playerMovement>().SlowDown();
	}
}