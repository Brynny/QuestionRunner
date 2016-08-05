using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour
{
	public GameObject gameController;
	

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			print ("hit");
			Destroy (other.gameObject);
			other.GetComponent<HSmodeController> ().GameOver ();
		}
	}
}
