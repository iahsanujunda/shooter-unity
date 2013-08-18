/*
 * Title:   destroyOnInvisible.cs
 * Author:  zlood
 * 
 * "Dumping memory allocation of every object that already leaving screen"
 * 
 * created on version 1
 * modification history:
 *  never
 *
 * 
**/


using UnityEngine;
using System.Collections;

public class destroyOnInvisible : MonoBehaviour {

	void OnBecameInvisible () {
		Destroy(gameObject);
	}
}
