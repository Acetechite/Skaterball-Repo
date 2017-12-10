using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform p1;
    public Transform p2;

    private Vector3 direction;


	void Start(){
	
	}
	
	// Update is called once per frame
	void Update () {
        direction = p2.position - p1.position;
        transform.rotation = Quaternion.LookRotation(direction);
	}
}


