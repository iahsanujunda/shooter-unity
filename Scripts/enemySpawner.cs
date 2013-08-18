/*
 * Title:   enemySpawner.cs
 * Author:  zlood
 * 
 * "Calls upon enemy objects to appear on screen"
 * 
 * created on version 3
 * modification history:
 *  version 4 "added enemy type probability"
 *  version 5 "optimize logic by transforming enemyType into array"
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class enemySpawner : MonoBehaviour {
	
	public GameObject[] enemies = new GameObject[3];
	public float spawnRadius = 0.01f;
	public float spawnDelay = 6.0f;
	
	public int enemyOneProb = 40;
	public int enemyTwoProb = 40;
	public int enemyThreeProb = 20;
	
	private int enemyType;
	
	void Start () {
		
		//call the first spawn
		Invoke("SpawnEnemy", spawnDelay);		
	}
	
	void SpawnEnemy () {
		
		//generate random number between 1 - 100
		int i = Random.Range(0,100);
		
		//if the result of random number is within Enemy One Probability, enter here
		if (i <= enemyOneProb) {
			enemyType = 0;
		}
		
		//if the result of random number is within Enemy Two Probability, enter here
		else if (i > enemyOneProb && i <= enemyOneProb + enemyTwoProb) {
			enemyType = 1;
		}
		
		//if the result of random number is within Enemy Three Probability, enter here
		else if (i > (100 - enemyThreeProb)) {
			enemyType = 2;
		}
		Vector3 spawnPosition = transform.position;
		Instantiate(enemies[enemyType], spawnPosition, enemies[enemyType].transform.rotation);
		Invoke("SpawnEnemy", spawnDelay);
	}
	
	void OnDrawGizmosSelected () {
		Gizmos.DrawWireSphere(transform.position, spawnRadius);
	}
}
