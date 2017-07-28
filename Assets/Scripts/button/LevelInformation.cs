using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation : MonoBehaviour {
	public GameObject[] Inform;
	bool[] islevelFinished;
	int whichLevelInfoIsDisplayed;

	public GameObject endUI;
	public GameObject end;
	// Use this for initialization
	void Awake () {
		islevelFinished = new bool[10];
		islevelFinished [0] = living_1.living1;
		islevelFinished [1] = living_2.living2;
		islevelFinished [2] = living_3.living3;
		islevelFinished [3] = living_4.living4;
		islevelFinished [4] = kitchen_1.kitchen1;
		islevelFinished [5] = kitchen_2.kitchen2;
		islevelFinished [6] = kitchen_3.kitchen3;
		islevelFinished [7] = bed_1.bed1;
		islevelFinished [8] = bed_2.bed2;
		islevelFinished [9] = bed_3.bed3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void openInform(){
		whichLevelInfoIsDisplayed = -1;
		for (int i = 0; i < 10; i++) {
			if (islevelFinished [i]) {
				Inform [i].SetActive (true);
				whichLevelInfoIsDisplayed = i;
				break;
			}
		}
	}
	public void changeLevelInfo(int offset){
		int targetlevel;
		for (int i = 1; i <= 10; i++) {
			targetlevel = whichLevelInfoIsDisplayed + (offset * i);
			if (targetlevel >= 10) {
				targetlevel -= 10;
			} else if (targetlevel <= -1) {
				targetlevel += 10;
			}
			if (islevelFinished [targetlevel]) {
				Inform [whichLevelInfoIsDisplayed].SetActive (false);
				Inform [targetlevel].SetActive (true);
				whichLevelInfoIsDisplayed = targetlevel;
				break;
			} else {
				continue;
			}
		}

	}
	public void closeInform(){
		this.GetComponent<Transform> ().GetChild (whichLevelInfoIsDisplayed).gameObject.SetActive (false);
		this.gameObject.SetActive (false);
		end.SetActive (true);
		endUI.SetActive (true);
	}
}
