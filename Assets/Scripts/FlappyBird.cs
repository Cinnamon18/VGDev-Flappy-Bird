using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour {
	public float jumpForce = 5;
	public int score = 0;
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			// GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
			Vector3 oldVelocity = GetComponent<Rigidbody>().velocity;
			GetComponent<Rigidbody>().velocity = new Vector3(oldVelocity.x, jumpForce, 0);
		}
	}

	private void OnCollisionEnter(Collision other) {
		print("flappy bit it :(");
		SceneManager.LoadScene(0);
	}

	private void OnTriggerEnter(Collider other) {
		score++;
		print(score);
	}
}
