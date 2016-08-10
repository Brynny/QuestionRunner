using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class correctAnswer : MonoBehaviour
{
	public Button speedUpButton;
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
		speedUpButton.onClick.AddListener(IncreaseSpeed);
	}

	void IncreaseSpeed()
	{
		player.GetComponent<playerMovement>().SpeedUp();
		Camera.main.gameObject.GetComponent<GameController>().QuestionsAnswered();
		Destroy(transform.parent.gameObject);
	}
}
