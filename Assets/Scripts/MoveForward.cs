using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = .7f;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
	
	}
	
	// Update is called once per frame
	void Update () {

		rb.velocity = new Vector2(this.transform.localScale.x, 0) * speed;
	
	}
}
