using UnityEngine;
using System.Collections;

public class GotApple : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Apple") {
			Destroy (other.gameObject);
			ScoreCounter.score += 1;
			ScoreCounter.text.text = ScoreCounter.score.ToString();
		}
	}
}
