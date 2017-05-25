using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*(speed), Input.GetAxis("Vertical")*(speed), 0);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
