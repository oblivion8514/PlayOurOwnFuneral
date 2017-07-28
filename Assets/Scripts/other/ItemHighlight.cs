using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHighlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void highlight(){
		print ("highlight function");
		this.gameObject.SetActive (true);
		Invoke ("offHighlight", 3f);
	}

	void offHighlight(){
		this.gameObject.SetActiveRecursively (false);
	}
	void OnMouseUp(){
		this.gameObject.SetActiveRecursively (false);
	}
}
