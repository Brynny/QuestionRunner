using UnityEngine;
using System.Collections;

public class CityRunnerFlag : MonoBehaviour
{
	float moveSpeed = 2f;
	private Rigidbody2D flagRB;

	// Use this for initialization
	void Start ()
	{
		flagRB = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		flagRB.velocity = Vector2.left * moveSpeed;
	}
}