using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ObstacleController : MonoBehaviour
{
	public float moveSpeed = 2f;
	private Rigidbody2D objectRB;

	// Use this for initialization
	void Start ()
	{
		objectRB = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		objectRB.velocity = Vector2.left * moveSpeed;
	}

	void LoadDefeatLevel()
	{
		SceneManager.LoadScene ("Defeat");
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			LoadDefeatLevel();
		}
	}
}