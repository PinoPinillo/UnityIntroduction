using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	public static int score, lives;
	public Text scoreText, livesText, endText;
	public GameObject player;
	private bool gameOver;

	// Use this for initialization
	void Start ()
	{
		score = 0;
		lives = 3;
		endText.text = "";
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		// Updates the texts.
		scoreText.text = "SCORE\n" + score.ToString ();
		livesText.text = "LIVES\n" + lives.ToString ();
		// If the player has collected all points, the game is over and shows the victory message.
		if (score == 60) {
			player.SetActive (false);
			endText.text = "YOU WIN!\nPress R to restart";
			gameOver = true;
		}
		// If the player has no lives, the game is over and shows the game over message.
		if (lives == 0) {
			player.SetActive (false);
			endText.text = "GAME OVER\nPress R to restart";
			gameOver = true;
		}
		// If the game is over, we can restart the game pressing r.
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene ("Main");
			}
		}
		// If we press the Escape key, exit the game.
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
