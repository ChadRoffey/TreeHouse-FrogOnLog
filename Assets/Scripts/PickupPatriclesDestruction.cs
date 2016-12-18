using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPatriclesDestruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		// Destroy the "pickkup particles" after 5 seconds
		Destroy (gameObject, 5f);

		}
}