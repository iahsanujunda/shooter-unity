/*
 * Title:   gameManager.cs
 * Author:  zlood
 * 
 * "Game play and GUI handler"
 * 
 * created on version 4
 * modification history:
 *  version 5 "added game play direction as GUI label"
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {
	
	public static int score = 0;
	public static bool gameover = false;
	
	private static int highScore = 0;
	
	void Update () {
		
		//If current score is more than Hi Score, store current score as the new Hi Score
		if (score > highScore){
			highScore = score;
		}
		
		//if game over
		if (gameover) {
			
			//wait 3 second, and then wait user input to restart the game
			StartCoroutine(Restart(3.0f));
		}
	}
	
	void OnGUI () {
		GUI.Label(new Rect(120, Screen.height/2.0f, 120, 20), "High Score : " + highScore.ToString());
		GUI.Label(new Rect(120, Screen.height/2.0f - 20, 120, 20), "Score : " + score.ToString());
        GUI.Label(new Rect(120, Screen.height - 20, 120, 20), "@zlood");
		
		if (gameover) {
			GUI.Label(new Rect(Screen.width/2.0f, Screen.height/2.0f - 40, 120, 20), "GAME OVER!");
			GUI.Label(new Rect(Screen.width/2.0f - 50, Screen.height/2.0f - 20, 300, 20), "Please wait 3 seconds and then,");
			GUI.Label(new Rect(Screen.width/2.0f - 50, Screen.height/2.0f, 300, 20), "Press UP arrow key to play again");
		}
		else if (!gameover) {
			GUI.Label(new Rect(Screen.width - 200, Screen.height/2.0f - 20, 120, 20), "Press UP arrow key");
			GUI.Label(new Rect(Screen.width - 200, Screen.height/2.0f, 120, 20), "to shoot");
		}
	}
	
	IEnumerator Restart (float waitTime) {
		yield return new WaitForSeconds(waitTime);
		
		//if UP arrow key is pressed
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			
			//reset all level variables, and then reload a new game
			gameover = false;
			score = 0;
			Application.LoadLevel("TestLevel");
		}
	}
}
