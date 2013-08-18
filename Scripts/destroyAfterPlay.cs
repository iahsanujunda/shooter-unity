/*
 * Title:   destroyAfterPlay.cs
 * Author:  zlood
 * 
 * "Dumping memory allocation of sound objects that finished playing"
 * 
 * created on version 5
 * modification history:
 *  never
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class destroyAfterPlay : MonoBehaviour {

	void Update () {
		
		//destroy the audio track after it is played
		if (!audio.isPlaying) {
			Destroy(gameObject);
		}
	
	}
}
