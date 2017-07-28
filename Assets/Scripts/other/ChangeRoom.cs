using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour {
	//0:living 1:kitchen 2:bedroom
	public static int roomNo;
	public GameObject [] roomScene;
	// Use this for initialization
	void Start () {
		roomNo = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void setRoom(int No){
		roomNo = No;
		roomScene[0].SetActive(false);
		roomScene[1].SetActive(false);
		roomScene[2].SetActive(false);
		roomScene[No].SetActive(true);
	}
}
