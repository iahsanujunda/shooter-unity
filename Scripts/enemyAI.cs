/*
 * Title:   enemyAI.cs
 * Author:  zlood
 * 
 * "Manipulator to enemy's behavior"
 * 
 * created on version 1
 * modification history:
 *  version 2 "added opposite screen edge spawner"
 *  version 3 "opposite screen edge spawn removed"
 * 
**/


using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

	public float speed = 15.0f;
	public int moveDirection;
	
	void Update () {
		
		//move the enemy to a predefined direction
		Vector3 newPosition = transform.position;
		newPosition.x += speed * moveDirection * Time.deltaTime;
		transform.position = newPosition;
		
		//if arrive on the edge of the screen, spawn to the opposite edge
		/*
		if (Camera.main.WorldToScreenPoint(transform.position).x > Screen.width) {
			moveDirection = 1;
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(0,0,cameraObjectZDifference)).x;
			transform.position = newPosition;
		}
		else if (Camera.main.WorldToScreenPoint(transform.position).x < 0) {
			moveDirection = -1;
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,0,cameraObjectZDifference)).x;
			transform.position = newPosition;
		}
		*/
	}
}
