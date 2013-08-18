/*
 * Title:   playerShoot.cs
 * Author:  zlood
 * 
 * "Handle player object's shooting action"
 * 
 * created on version 1
 * modification history:
 *  never
 * 
 * 
**/


using UnityEngine;
using System.Collections;

public class playerShoot : MonoBehaviour {
	
	public GameObject bullet;
	public float shootDelay = 0.2f;
	public float bulletSpeed = 60.0f;
	
	private bool canShoot = true;
	
	void Update () {
	
		if (Input.GetKey(KeyCode.UpArrow) && canShoot) {
			
			//Instantiate Bullet Object
			GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			
			//commit shooting action
			Vector3 shootVelocity = Vector3.zero;
			shootVelocity.y = bulletSpeed;
			bulletInstance.rigidbody.velocity = shootVelocity;
			canShoot = false;
			Invoke("ShootDelay", shootDelay);
		}
	}
	
	void ShootDelay () {
		canShoot = true;
	}
}