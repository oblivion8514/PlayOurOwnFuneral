using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeCalender : MonoBehaviour {
	public GameObject calender;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		calender.SetActive (false);
	}
}
