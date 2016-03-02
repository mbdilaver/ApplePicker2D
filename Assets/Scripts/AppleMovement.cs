using UnityEngine;
using System.Collections;

public class AppleMovement : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float fallSpeed;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		rb2d.velocity = new Vector2 (0, fallSpeed * -1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
