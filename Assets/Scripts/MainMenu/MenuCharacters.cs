using UnityEngine;
using System.Collections;

public class MenuCharacters : MonoBehaviour 
{
	private Rigidbody2D menuChar;

	[SerializeField] private float moveSpeed;
	[SerializeField] private float maxSpeed;

	void Start ()
	{
		menuChar = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
		menuChar.AddForce (Vector2.right * moveSpeed);
		if(menuChar.velocity.magnitude > maxSpeed)
		{
			menuChar.velocity = menuChar.velocity.normalized * maxSpeed;
		}
	}
}