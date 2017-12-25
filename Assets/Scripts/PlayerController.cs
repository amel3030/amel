using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rb2d;

	public float speed = 1.5f;
	void Update()
	{
		if (Input.GetKey(KeyCode.A)||(Input.GetKey(KeyCode.LeftArrow)))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)||(Input.GetKey(KeyCode.RightArrow)))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W)||(Input.GetKey(KeyCode.UpArrow)))
		{
			transform.position += Vector3.up * 15 * Time.deltaTime;
		}

		if((Input.GetKey(KeyCode.R))) //reset key
		{
			transform.position = new Vector3(0, 5, 1);
		}

		if (transform.position.y <= -50f)
		{
			transform.position = new Vector3(0, 5, 1);
		}
			
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Portal"))
			transform.position = new Vector3 (0, 5, 1);
	}
}
