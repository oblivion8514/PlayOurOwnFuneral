using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPreviewAndUse : MonoBehaviour {
	public GameObject targetObj;
	public bool used;
	GameObject UI;
	// Use this for initialization
	void Start () {
		UI = GameObject.Find ("UImanager");
		used = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		if (used) {
			this.GetComponent<SpriteRenderer> ().color = Color.white;
			used = false;
			UImanager.usingitem = false;
		} else {
			UImanager.usingitem = true;
			UI.GetComponent<UImanager> ().cancelItemUse ();
			this.GetComponent<SpriteRenderer> ().color = Color.red;
			used = true;
		}
		//print (UImanager.usingitem);
	}
	void OnMouseEnter(){
		targetObj.SetActive (true);
	}
	void OnMouseExit(){
		targetObj.SetActive (false);
	}
}
