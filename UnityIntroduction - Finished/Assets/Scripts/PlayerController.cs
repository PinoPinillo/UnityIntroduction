using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	// Movement speed.
	public float speed;
	
	// Update is called once per frame
	void Update ()
	{
		// Gets the movement vector.
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		// Adds a force to the player rigidbody to move it.
		this.GetComponent<Rigidbody> ().AddForce (movement * speed);
	}

	void OnTriggerEnter (Collider other)
	{
		// If the player hits a point, increases the score.
		if (other.CompareTag ("Point")) {
			GameController.score++;
		}
		// If the player hits an enemy, decreases lives by one.
		if (other.CompareTag ("Enemy")) {
			GameController.lives--;
		}

		Destroy (other.gameObject);
	}
}
