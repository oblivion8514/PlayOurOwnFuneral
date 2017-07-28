using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		Application.ExternalEval ("window.open(\"https://planyourownfuneral.wixsite.com/2017\")");
		//GameObject.Find("Script").GetComponent<Link>().OpenLinkJSPlugin();
	}
}
