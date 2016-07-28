using UnityEngine;
using System.Collections;

public class HurdlesJump : MonoBehaviour
{
	private bool jump;

	private Rigidbody2D myRigidbody;

	[SerializeField]
	private Transform[] groundPoints;

	[SerializeField]
	private float groundRadius;

	[SerializeField]
	private LayerMask whatIsGround;

	private bool isGrounded;

	[SerializeField]
	private float jumpForce;


	void Start () 
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}
	

	void Update ()
	{
		HandleInput();
	}

	void FixedUpdate()
	{
		isGrounded = IsGrounded();

		if (isGrounded && jump)
		{
			isGrounded = false;
			myRigidbody.AddForce(new Vector2(0, jumpForce));
			jump = false;
		}

	}

	private void HandleInput()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			jump = true;
		}
	}

	private bool IsGrounded()
	{
		if(myRigidbody.velocity.y <= 0)
		{
			foreach (Transform point in groundPoints)
			{
				Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

				for (int i = 0; i < colliders.Length; i++)
				{
					if(colliders[i].gameObject != gameObject)
					{
						return true;
					}
				}
			}
		}
		return false;
	}
}
