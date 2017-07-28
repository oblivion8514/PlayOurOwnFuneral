using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UImanager : MonoBehaviour {
	public int defaultTime;
	public Text timetext;
	public GameObject[] item;
	public static bool usingitem;
	public Image progress;
	// Use this for initialization
	void Start () {
		//print ("test");
		usingitem = false;
		//InvokeRepeating ("timer", 0.5f, 1f);
		this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void starttimer(){
		InvokeRepeating("timer",0f,1f);
	}
	void timer(){
		defaultTime--;
		timetext.text = defaultTime / 60 + " : " + defaultTime % 60;
		if (defaultTime == 0||progress.fillAmount==1f) {
			Invoke ("toEnd", 0.9f);
		}
	}
	public void stoptimer(){
		CancelInvoke ("timer");
	}
	public void cancelItemUse(){
		for (int i = 0; i < 10; i++) {
			item [i].GetComponent<SpriteRenderer> ().color = Color.white;
			item [i].GetComponent<ItemPreviewAndUse> ().used = false;
		}
		usingitem = false;
	}
	void toEnd(){
		GameManager.score = (int)(progress.fillAmount * 10);
		SceneManager.LoadScene (2);
	}

}
