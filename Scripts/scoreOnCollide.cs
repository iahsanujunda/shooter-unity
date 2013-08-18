/*
 * Title:   scoreOnCollide.cs
 * Author:  zlood
 * 
 * "Scoring system handler"
 * 
 * created on version 4
 * modification history:
 *  never
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class scoreOnCollide : MonoBehaviour {
	
	public int pointValue;
	
	void OnCollisionEnter () {
		gameManager.score += pointValue;
	}
}
