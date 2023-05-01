using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour {
	public GameObject pikachu;
	public GameObject variableImage;
	public GameObject charmander;
	public Sprite[] imageArray;
	public GameObject partyHat;
	public void partyHatAppear(bool value){
		partyHat.SetActive (value);
	}
	public void showPokemon(int which){
		if (which == 0) {
			pikachu.SetActive (true);
			charmander.SetActive (false);
		} else {
			pikachu.SetActive (false);
			charmander.SetActive (true);
		}

	}
	void Start(){
		charmander.SetActive (false);
	}
	/*public void dropDown(int num){
		if (num == 0) {
			//Debug.Log("Pikachu");
			variableImage.GetComponent<Image>().sprite = imageArray [0];
		}
		if (num == 1) {
			//Debug.Log("Charmander");
			variableImage.GetComponent<Image>().sprite = imageArray [1];
		}
	}

	public void pikachuAppear(bool value){
		pikachu.SetActive (value);
	}
	public void charmanderAppear(bool value){
		charmander.SetActive (value);
	}*/

}
