using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 200;
	public float maxSpeed = 5;
	public Rigidbody2D rb;
	public int moving = 0;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("right")) {
			moving = 1;
		} else if (Input.GetKey ("left")) {
			moving = -1;
		} else {
			moving = 0;
		}

		if (moving != 0) {
			var velocityX = System.Math.Abs (rb.velocity.x);

			if (velocityX < .5) {
				rb.AddForce (new Vector2 (moving, 0) * speed);
			}
		
			if (this.transform.localScale.x != moving) {
				transform.localScale = new Vector2(moving, 1);
			}

			if (velocityX > maxSpeed) {
				rb.velocity = new Vector2 (maxSpeed * moving, 0);
			}

		}
	}
}
