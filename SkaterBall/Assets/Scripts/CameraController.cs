using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject kamera;  // Assign the object that spins in x,y,z
	public Quaternion rotacja = Quaternion.identity;

	private Rigidbody rb;


	void Start(){
		rb = kamera.GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (kamera.transform);
		//transform.position = transform.TransformDirection (rb.velocity);
		//rotacja.eulerAngles = new Vector3 (transform.rotation.eulerAngles.x, kamera.transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.x);
		//transform.rotation = rotacja;
	}
}


