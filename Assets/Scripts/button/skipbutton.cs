using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skipbutton : MonoBehaviour {
	public GameObject obj;
	public GameObject tarObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter(){
		obj.SetActive (false);
		tarObj.SetActive (true);
	}
	void OnMouseExit(){
		obj.SetActive (true);
		tarObj.SetActive (false);
	}
	void OnMouseUp(){
		//Application.OpenURL ("https://mark11028.wixsite.com/nccu");
		Application.ExternalEval ("window.open(\"https://planyourownfuneral.wixsite.com/2017\")");
		//GameObject.Find("Script").GetComponent<Link>().OpenLinkJSPlugin();
	}
}
