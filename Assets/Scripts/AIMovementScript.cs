using UnityEngine;
using System.Collections;

public class AIMovementScript : MonoBehaviour
{
	private Rigidbody2D AIChar;
	public Animator animator;

	[SerializeField] public float maxSpeed;
	[SerializeField] public float moveSpeed;

	public float runSpeed;
	float timer = 5f;

	// Use this for initialization
	void Start ()
	{
		AIChar = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
	}

	void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal");
		if (timer <= 0)
		{
			runSpeed += Time.deltaTime * moveSpeed;
			HandleMovement(horizontal);
			timer = 0;
		}

		if (maxSpeed <= 0)
		{
			maxSpeed = 0;
		}

		if (maxSpeed >= 20)
		{
			maxSpeed = 20;
		}

		if (runSpeed <= 0)
		{
			runSpeed = 0;
			animator.speed = 0;
		}

		if (runSpeed > 0)
		{
			animator.speed = 1;
		}
	}

	public void HandleMovement(float horizontal)
	{
		AIChar.AddForce (Vector2.right * runSpeed);
		if(AIChar.velocity.magnitude > maxSpeed)
		{
			AIChar.velocity = AIChar.velocity.normalized * maxSpeed;
		}
	}
}