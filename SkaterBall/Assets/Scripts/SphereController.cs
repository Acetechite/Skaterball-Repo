using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

	public Rigidbody rb;
	public float speed;
	public Vector3 velo;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void Update () {
		float speedX = Input.GetAxis ("Vertical") * speed;
		float speedZ = Input.GetAxis ("Horizontal") * speed;

		velo = new Vector3 (speedZ, 0f, speedX);
		rb.AddForce(velo);
	}
}
