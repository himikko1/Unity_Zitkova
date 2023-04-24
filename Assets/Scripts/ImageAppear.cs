using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAppear : MonoBehaviour {
	public GameObject pikachu;
	public GameObject charmander;

	public void pikachuAppear(bool value){
		pikachu.SetActive (value);
	}
	public void charmanderAppear(bool value){
		charmander.SetActive (value);
	}


}