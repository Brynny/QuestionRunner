using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wrongAnswer : MonoBehaviour 
{
	public Button slowDownButton;
	public GameObject player;

	public void Update()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnEnable()
	{
		slowDownButton.onClick.AddListener(DecreaseSpeed);
	}

	void DecreaseSpeed()
	{
		player.GetComponent<playerMovement>().SlowDown();
		Destroy(transform.parent.gameObject);
	}
}