using UnityEngine;
using System.Collections;

public class SpawnApple : MonoBehaviour {

	private Vector2 currentPosition;
	public GameObject dropObject;
	public float applePerSecond;
	public float jackSpeed;
	public float changeToChangeDirections;
	private Vector2 targetPosition;
	private Vector3 screen;
	private float screenWidth;

	void Start () {
		currentPosition = transform.position;
		targetPosition = currentPosition;

		screen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
		//print (screen.x);
		screen.x -= 1.0f;
		//print (screen.x);
		float appleTime = 1.0f / applePerSecond;
		InvokeRepeating ("SpawnObject", 0, appleTime);

	}

	void SpawnObject() {
		//print ("SpawnObject");
		/*
		float posX = transform.position.x;
		posX += Random.Range (-5.0f, 5.0f);
		if (posX < -10 || posX > 10) {
			posX = 0;
		}

		currentPosition.x = posX;
		targetPosition = new Vector2(posX, currentPosition.y); */

		Instantiate (dropObject, transform.position, Quaternion.identity);
	}

	void Update() {
		float posX = currentPosition.x;
		posX += jackSpeed * Time.deltaTime;
		//currentPosition.x = Mathf.Sin(Time.realtimeSinceStartup * 2.0f)*10.0f;
		//currentPosition.y = Mathf.Sin (Time.realtimeSinceStartup * 2.0f) * Mathf.Cos (Time.realtimeSinceStartup * 2.0f);
		currentPosition.x = posX;
		transform.position = currentPosition;
		//if (posX < -10) {
		if (posX < -1 * (screen.x)) {
			jackSpeed = Mathf.Abs (jackSpeed);
		//} else if (posX > 10) {
		} else if (posX > screen.x) {
			jackSpeed = -1 * Mathf.Abs (jackSpeed);
		}
		/*
		if ((int)(Time.realtimeSinceStartup) % 5 == 0) {
			if (jackSpeed > 0) {
				jackSpeed += 4;
			} else
				jackSpeed -= 4;
		}*/


			
	}
	/*
	void OnBecameInvisible() {
		jackSpeed *= -1;
	}*/
		
	void FixedUpdate () {
		//print ("FixedUpdate");
		//transform.position = Vector2.Lerp(transform.position, targetPosition, jackSpeed * 1.0f * Time.fixedDeltaTime);
		if (Random.value < changeToChangeDirections) {
			jackSpeed *= -1;
		}
	}
}
