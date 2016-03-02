using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public static int score;
	public static Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//text.text = score.ToString();
	}
}
