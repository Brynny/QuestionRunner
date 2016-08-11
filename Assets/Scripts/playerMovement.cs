using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour 
{
	private Rigidbody2D playerChar;
	public Animator animator;
	public Text distanceTravelledText;

	float distanceTravelled = 0f;
	float maxDistance = 200f;
	Vector2 lastPosition;

	public Image Bar;

	[SerializeField] public float moveSpeed;
	[SerializeField] public float maxSpeed;

	//Jump Variables
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	// Use this for initialization
	void Start ()
	{
		lastPosition = transform.position;
		playerChar = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		distanceTravelled += Vector2.Distance(transform.position, lastPosition) * 2;
		lastPosition = transform.position;
		int metersTravelled = Mathf.RoundToInt(distanceTravelled);
		distanceTravelledText.text = metersTravelled + " metres";
		
	}

	void FixedUpdate()
	{
		//Make animator speed half of movement speed
		animator.speed = moveSpeed * 0.5f;

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
		travelledDistance();
		CheckGrounded();
	}

	void travelledDistance()
	{
		float calc_Distance = distanceTravelled / maxDistance; 
		SetDistanceTravelledBar(calc_Distance);
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
	}

	public void SlowDown()
	{
		moveSpeed = moveSpeed - 0.5f;
		maxSpeed = maxSpeed - 0.5f;
	}

	public void CheckGrounded()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
	}

	public void JumpPlayer()
	{
		playerChar.velocity = new Vector2(playerChar.velocity.x, jumpHeight);
	}

	public void SetDistanceTravelledBar (float distanceTravelled)
	{
		Bar.transform.localScale = new Vector3(distanceTravelled, Bar.transform.localScale.y, Bar.transform.localScale.z);
	}
}
