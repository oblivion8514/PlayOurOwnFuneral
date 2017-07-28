using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCalender : MonoBehaviour {
	public GameObject targetObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		targetObj.SetActive (true);
	}
}
