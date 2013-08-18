/* 
 * Title:   debrisOnCollide.cs
 * Author:  zlood
 * 
 * "Effect handler upon collision between two objects"
 * 
 * created on version 1
 * modification history:
 *  version 5 "added sound effect handler"
 * 
 * 
**/


using UnityEngine;
using System.Collections;

public class debrisOnCollide : MonoBehaviour {

	public GameObject[] debrises;
	public GameObject debrisSound;
	public float explosiveRadius = 1.0f;
	public float explosiveForce = 100.0f;
	
	void OnCollisionEnter () {
		
		//call every debris element in debrises[] array
		foreach (GameObject debris in debrises) {
			
			//instantiate the debrises
			GameObject debrisInstance = Instantiate(debris, transform.position + Random.insideUnitSphere * explosiveRadius, transform.rotation) as GameObject;
			
			//make explosion effect
			debrisInstance.rigidbody.AddExplosionForce(explosiveForce,transform.position,explosiveRadius);			
		}
		
		//instantiate sound
		GameObject soundInstance = Instantiate(debrisSound, transform.position, transform.rotation) as GameObject;
		Destroy(gameObject);
	}
}
