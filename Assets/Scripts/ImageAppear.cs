using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAppear : MonoBehaviour {
	public GameObject pikachu;

	public void pikachuAppear(bool value){
		pikachu.SetActive (value);
	}


}