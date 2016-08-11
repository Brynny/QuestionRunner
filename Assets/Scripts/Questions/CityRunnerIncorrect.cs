using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CityRunnerIncorrect : MonoBehaviour 
{
	public Button failButton;
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
		failButton.onClick.AddListener(DontJump);
	}

	void DontJump()
	{
		Camera.main.GetComponent<GameController>().WrongAnswer();
		Destroy(transform.parent.gameObject);
	}
}
