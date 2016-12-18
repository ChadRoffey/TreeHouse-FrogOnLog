using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour {

	[SerializeField]
	private GameObject pickupPrefab;

	void OnTriggerEnter(Collider other) {

		//If collider other is tagged tagged with "player"
		if (other.CompareTag ("Player")) {

			//...add the pickup particles...
			Instantiate (pickupPrefab, transform.position, Quaternion.identity);

			Destroy (gameObject);

		}
	}

}