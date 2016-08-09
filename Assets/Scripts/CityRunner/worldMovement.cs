using UnityEngine;
using System.Collections;

public class worldMovement : MonoBehaviour 
{
	float moveSpeed = 2f;
	private Rigidbody2D myRB;

	// Use this for initialization
	void Start ()
	{
		myRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		myRB.velocity = Vector2.left * moveSpeed;
	}
}
