using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class living_2detection : MonoBehaviour {
	public GameObject Obj;
	public GameObject tarObj;
	public GameObject living2Object;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (living_2.living2progress == 2) {
			Obj.SetActive (false);
			tarObj.SetActive (true);
			living2Object.GetComponent<living_2> ().setliving2 (); 
		}
	}
}
