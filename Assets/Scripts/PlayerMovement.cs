using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Animator playerAnimator;
	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;

	// Use this for initialization
	void Start () {
		playerAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		moveHorizontal = Input.GetAxisRaw ("Horizontal");
		moveVertical = Input.GetAxisRaw ("Vertical");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

	void FixedUpdate () {

		if (movement != Vector3.zero) {
			playerAnimator.SetFloat ("Speed", 3f);
		} else {playerAnimator.SetFloat ("Speed", 0f);
		}

	}
}
