/*
 * Title:   shootAtPlayer.cs
 * Author:  zlood
 * 
 * "Manipulator to enemy's behavior to shoot upon player's position"
 * 
 * created on version 4
 * modification history:
 *  version 5 "added default shooting direction upon player's death"
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class shootAtPlayer : MonoBehaviour {
	
	public GameObject bullet;
	public float bulletSpeed = 10.0f;
	
	private float shootDelay = Random.Range(0.3f, 2.0f);
	
	void Start () {
		Invoke("Shoot", shootDelay);	
	}

	void Shoot () {
		
		//Check if player is still alive, if it is do this
		if (GameObject.FindGameObjectWithTag("Player")) {
			
			//get the position of the player at the time this method called
			Vector3 playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
			
			//set the player position as shooting direction
			Vector3 shootDirection = (playerPosition - transform.position).normalized;
			
			//commit shooting action
			GameObject bulletInstance = Instantiate(bullet, transform.position, Quaternion.LookRotation(shootDirection)) as GameObject;
			bulletInstance.rigidbody.AddForce(shootDirection * bulletSpeed, ForceMode.VelocityChange);
			Invoke("Shoot", shootDelay);
		}
		
		//if player is not alive, do this
		else if (!GameObject.FindGameObjectWithTag("Player")) {
			
			//set shoot direction vertically below
			Vector3 shootDirection = Vector3.zero;
			shootDirection.y = -bulletSpeed;
			
			//commit shooting action
			GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			bulletInstance.rigidbody.velocity = shootDirection;
			Invoke("Shoot", shootDelay);
		}
	}
}