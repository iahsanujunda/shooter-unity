/*
 * Title:   moveHorizontal.cs
 * Author:  zlood
 * 
 * "Manipulator to player object's horizontal position based on user input"
 * 
 * created on version 1
 * modification history:
 *  version 3 "added screen width limitation"
 *
 * 
**/



using UnityEngine;
using System.Collections;

public class moveHorizontal : MonoBehaviour {

	public float speed = 1.0f;

	void Update () {
		
		Vector3 newPosition = transform.position;
		newPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		transform.position = newPosition;
		
		//make sure the player aren't moving out of the screen
		//if the player is on the right edge, keep it right there
		if (Camera.main.WorldToScreenPoint(transform.position).x > Screen.width) {		
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width - 10,0,cameraObjectZDifference)).x;
			transform.position = newPosition;			
		}
		
		//if the player is on the left edge, keep it right there
		else if (Camera.main.WorldToScreenPoint(transform.position).x < 0) {
			newPosition = transform.position;
			float cameraObjectZDifference = transform.position.z - Camera.main.transform.position.z;
			newPosition.x = Camera.main.ScreenToWorldPoint(new Vector3(10,0,cameraObjectZDifference)).x;
			transform.position = newPosition;
		}
	}
}
