using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class living_4 : MonoBehaviour {
	public GameObject[] arrowPrefab;

	class key{
		public GameObject obj;
		public int flag;

		public key(GameObject _obj,int _flag){
			obj=_obj;
			flag=_flag;
		}
	}
	public static bool living4;
	public Image progress;

	public GameObject suonacollider;
	public GameObject suonaGame;
	GameObject telephone;

	int gameflag=0;
	List<key> list=new List<key>();
	System.Random ran;
	// Use this for initialization
	void Awake () {
		telephone = GameObject.Find ("telephoneRing");
		living4 = false;
		ran=new System.Random();
		//generate ();
	}
	void Start(){
		living4 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameflag < 12) {
			if (Input.GetKeyUp (KeyCode.LeftArrow)) {
				if (list [gameflag].flag == 2) {
					list [gameflag].obj.transform.GetChild (0).gameObject.SetActive (false);
					list [gameflag].obj.transform.GetChild (1).gameObject.SetActive (true);
					gameflag++;
				} else
					suonaGameFail ();
			}
			if (Input.GetKeyUp (KeyCode.RightArrow)) {
				if (list [gameflag].flag == 0) {
					list [gameflag].obj.transform.GetChild (0).gameObject.SetActive (false);
					list [gameflag].obj.transform.GetChild (1).gameObject.SetActive (true);
					gameflag++;

				} else
					suonaGameFail ();
			}
			if (Input.GetKeyUp (KeyCode.UpArrow)) {
				if (list [gameflag].flag == 1) {
					list [gameflag].obj.transform.GetChild (0).gameObject.SetActive (false);
					list [gameflag].obj.transform.GetChild (1).gameObject.SetActive (true);
					gameflag++;

				} else
					suonaGameFail ();
			}
			if (Input.GetKeyUp (KeyCode.DownArrow)) {
				if (list [gameflag].flag == 3) {
					list [gameflag].obj.transform.GetChild (0).gameObject.SetActive (false);
					list [gameflag].obj.transform.GetChild (1).gameObject.SetActive (true);
					gameflag++;

				} else
					suonaGameFail ();
			}
		}
		if (!living4 && gameflag == 12) {
			living4 = true;
			Invoke("setliving4" ,1f);
		}
	}
	public void generate(){
		//if (telephone.GetComponent<AudioSource> ().isPlaying) {
		telephone.GetComponent<AudioSource> ().volume *= 0.5f;
		if (list.Count != 0) {
			for (int i = 0; i < 12; i++) {
				Destroy (list [i].obj);
			}
		}
		list.Clear ();
		gameflag = 0;
		//int Case=ran.Next(6,13)
		for (int i = 0; i < 12; i++) {
			Vector3 pos = new Vector3 (-5.5f + (float)i, 0f, -0.1f);
			int n = ran.Next (0, 4);
			if (n == 0) {
				GameObject _obj = Instantiate (arrowPrefab [0], pos,Quaternion.Euler(Vector3.zero));
				_obj.transform.parent = this.gameObject.transform;
				list.Add (new key (_obj, 0));
			} else if (n == 1) {
				GameObject _obj = Instantiate (arrowPrefab [1], pos,Quaternion.Euler(Vector3.zero));
				_obj.transform.parent = this.gameObject.transform;
				list.Add (new key (_obj, 1));
			} else if (n == 2) {
				GameObject _obj = Instantiate (arrowPrefab [2], pos,Quaternion.Euler(Vector3.zero));
				_obj.transform.parent = this.gameObject.transform;
				list.Add (new key (_obj, 2));
			} else if (n == 3) {
				GameObject _obj = Instantiate (arrowPrefab [3], pos,Quaternion.Euler(Vector3.zero));
				_obj.transform.parent = this.gameObject.transform;
				list.Add (new key (_obj, 3));
			}
			//print (i +":"+list [i].flag);
			this.GetComponent<AudioSource>().Play();
		}
	}
	void setliving4(){
		living4 = true;
		progress.fillAmount += 0.1f;
		telephone.GetComponent<AudioSource> ().volume *= 2f;
		progress.GetComponent<AudioSource> ().Play ();
		this.gameObject.SetActive (false);
		suonacollider.SetActive (false);
		suonaGame.SetActive (false);
		this.GetComponent<AudioSource> ().Stop ();
	}
	void suonaGameFail(){
		this.GetComponent<AudioSource> ().Stop ();
		suonaGame.SetActive (false);
		telephone.GetComponent<AudioSource> ().volume *= 2f;
	}
	//public 

	void OnMouseUp(){
		suonaGameFail ();
	}
}
