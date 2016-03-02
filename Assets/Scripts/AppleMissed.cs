using UnityEngine;
using System.Collections;

public class AppleMissed : MonoBehaviour {

	public GameObject basket1;
	public GameObject basket2;
	public GameObject basket3;

	private int basketNum = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Apple") {
			if (basketNum == 1) {
				Destroy (basket1);
				basketNum++;
			} else if (basketNum == 2) {
				Destroy (basket2);
				basketNum++;
			} else if (basketNum == 3) {
				Destroy (basket3);
				basketNum++;
			} else {
				print ("Game Over");
				ScoreCounter.text.text = "Game Over";
			}
			Destroy (other.gameObject);
			print ("Missed apple");
		}
	}
}
