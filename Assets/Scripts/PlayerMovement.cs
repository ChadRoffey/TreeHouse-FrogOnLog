using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Animator playerAnimator;
	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;
	private float turningSpeed = 20f;
	private Rigidbody playerRigidBody;
	[SerializeField]
	private RandomSoundPlayer playerFootsteps;

	// Use this for initialization
	void Start () {
		
		//Gather the copmonents from the Player GameObject
		playerAnimator = GetComponent<Animator> ();
		playerRigidBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		// Gather input from the keyboard
		moveHorizontal = Input.GetAxisRaw ("Horizontal");
		moveVertical = Input.GetAxisRaw ("Vertical");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
	}

	void FixedUpdate () {

		//If the player's movement vector does not equal zero...
		if (movement != Vector3.zero) {

			//...then create a targert roation based on the movement vectot..,
			Quaternion targetRoation = Quaternion.LookRotation(movement, Vector3.up);

			//..and create another rotation the moves from the current rotation to the target rotation
			Quaternion newRotation = Quaternion.Lerp(playerRigidBody.rotation, targetRoation, turningSpeed * Time.deltaTime);

			//...and change the player's roation to the new incremental roation...
			playerRigidBody.MoveRotation(newRotation);

			// Than play the jump animation...
			playerAnimator.SetFloat ("Speed", 3f);

			// ... Play footstep sounds.
			playerFootsteps.enabled = true;

		} else {
			// Otherwise don't play the animation...
			playerAnimator.SetFloat ("Speed", 0f);

			// Don't play footstep sounds.
			playerFootsteps.enabled = false;
		}

	}
}
