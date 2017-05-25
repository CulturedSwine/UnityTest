using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	public bool plateActive = false;
	void OnTriggerEnter2D (Collider2D other){
		plateActive=true;
		Debug.Log (plateActive);
	}
		void OnTriggerExit2D (Collider2D other){
			plateActive=false;
		Debug.Log (plateActive);
	}
}
