/*
 * Title:   gameoverOnCollide.cs
 * Author:  zlood
 * 
 * "Event Handler to change game status to game over"
 * 
 * created on version 4
 * modification history:
 *  never
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class gameoverOnCollide : MonoBehaviour {
	
	void OnCollisionEnter () {
		gameManager.gameover = true;
	}
}
