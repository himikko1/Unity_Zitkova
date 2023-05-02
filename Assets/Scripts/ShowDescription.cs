using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour {
	public GameObject pikachuD;
	public GameObject charmanderD;
	public void showDesc(int x){
		if (x == 0) {
			pikachuD.SetActive (true);
			charmanderD.SetActive (false);
		} else {
			pikachuD.SetActive (false);
			charmanderD.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
		pikachuD.SetActive (true);
		charmanderD.SetActive (false);
	}

}
