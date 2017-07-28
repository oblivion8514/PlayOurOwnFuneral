using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room : MonoBehaviour {
	public int offset;
	public GameObject changeRoom;
	public GameObject click;
	public GameObject click1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseUp(){
		int no = ChangeRoom.roomNo + offset;
		if (no > 2)
			no = no - 3;
		else if (no < 0)
			no = no + 3;
		changeRoom.GetComponent<ChangeRoom> ().setRoom (no);
	}
	void OnMouseEnter(){
		click.SetActive (false);
		click1.SetActive (true);
	}
	void OnMouseExit(){
		click.SetActive (true);
		click1.SetActive (false);
	}
}
