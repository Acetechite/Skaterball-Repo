using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

	public Rigidbody rb;
	public float speed;
    public float jump;
    public float rot;
	public Vector3 velo;

    public Transform p1;
    public Transform p2;

    public Vector3 dis;
    public Vector3 dir;

    public bool contactGround;

    public Vector3 realUp;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();	
	}
	
	// Update is called once per frame
	void Update () {

        //Position changing
        p1.transform.position = transform.position;
        //Rotation of Dir
        float speed2 = Input.GetAxis("Horizontal") * Time.deltaTime * rot;
        p1.transform.Rotate(Vector3.up, speed2);


        float speedX = Input.GetAxis ("Vertical") * speed;

        dir = p2.position - p1.position;
        
		velo = dir*speedX;
        
        rb.AddForce(velo);
        
	}
    
    public Vector3 UnitVector(Vector3 vec)
    {
        float unit = Mathf.Sqrt(vec.x * vec.x + vec.y * vec.y + vec.z * vec.z);
        Vector3 uVec = new Vector3(vec.x/unit,vec.y/unit,vec.z/unit);
        return uVec;
    }


}
