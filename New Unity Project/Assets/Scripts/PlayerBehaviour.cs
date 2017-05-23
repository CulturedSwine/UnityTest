using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
