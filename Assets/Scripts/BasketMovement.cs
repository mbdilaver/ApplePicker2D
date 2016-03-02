using UnityEngine;
using System.Collections;

public class BasketMovement : MonoBehaviour {

	private Transform currentTransform;
	// Position of the mouse in the game space
	private Vector3 mousePosition;
	// Use this for initialization
	void Start () {
		currentTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		Vector3 mousePos = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint (mousePos);
		// Move basket only on the x axis
		currentTransform.transform.position = new Vector3 (mousePosition.x, currentTransform.transform.position.y, 0);
	}
}
