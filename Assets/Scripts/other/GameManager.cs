using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {
	//singleton
	//單例模式
	public static int gender;//1:M 2:F
	public static int age;//1:70down 2.70up
	public static int score;
	void Awake () {

		gender = 0;
		age = 0;
		score = 0;
		DontDestroyOnLoad (this);
     
	}

	void Update () {
		
	}
	public static void resetplayerSetting(){
		living_1.living1 = false;
		living_2.living2 = false;
		living_2.living2progress = 0;
		living_3.living3 = false;
		living_4.living4 = false;
		kitchen_1.kitchen1 = false;
		kitchen_2.kitchen2 = false;
		kitchen_3.kitchen3 = false;
		bed_1.bed1 = false;
		bed_2.bed2 = false;
		bed_3.bed3 = false;
		gender=0;
		age=0;
		score = 0;
	}
}
