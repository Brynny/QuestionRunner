using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour 
{
	private Rigidbody2D playerChar;
	public Animator animator;

	[SerializeField] public float moveSpeed;
	[SerializeField] public float maxSpeed;

	// Use this for initialization
	void Start ()
	{
		playerChar = GetComponent<Rigidbody2D>();
		moveSpeed = 0;
		maxSpeed = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal");
		HandleMovement(horizontal);

		if (maxSpeed <= 0)
		{
			maxSpeed = 0;
			animator.speed = 0;
		}

		if (moveSpeed <= 0)
		{
			moveSpeed = 0;
		}
	}

	public void HandleMovement(float horizontal)
	{
		playerChar.AddForce (Vector2.right * moveSpeed);
		if(playerChar.velocity.magnitude > maxSpeed)
		{
			playerChar.velocity = playerChar.velocity.normalized * maxSpeed;
		}
	}

	public void SpeedUp()
	{
		moveSpeed = moveSpeed + 0.5f;
		maxSpeed = maxSpeed + 0.5f;
		animator.speed = animator.speed + 0.25f;
	}

	public void SlowDown()
	{
		moveSpeed = moveSpeed - 0.5f;
		maxSpeed = maxSpeed - 0.5f;
		animator.speed = animator.speed - 0.25f;
	}
}
