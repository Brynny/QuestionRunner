using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CityRunnerJump : MonoBehaviour 
{
	public Button jumpButton;
	public GameObject player;

	public void Start()
	{

	}

	public void Update()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnEnable()
	{
		jumpButton.onClick.AddListener(Jump);
	}

	void Jump()
	{
		player.GetComponent<playerMovement>().JumpPlayer();
		Destroy(transform.parent.gameObject);
	}
}
