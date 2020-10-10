using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvasUpdater : MonoBehaviour {
	public Text scoreText;
	public FlappyBird flappyBird;

	// Update is called once per frame
	void Update() {
		scoreText.text = "Score: " + flappyBird.score;
	}
}
