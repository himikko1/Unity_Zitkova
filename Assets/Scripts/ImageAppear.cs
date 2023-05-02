using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAppear : MonoBehaviour {
	public GameObject pikachu;
	public GameObject charmander;
	public GameObject variableImage;
	public Sprite[] imageArray;
	public GameObject partyHat;
	public GameObject scarf;
	public GameObject slider;
	public void changeSize(){
		float trueValue = slider.GetComponent<Slider> ().value;
		variableImage.transform.localScale = new Vector3 (1F * trueValue, 1F * trueValue, 1);
	}
	public void scarfAppear(bool value){
		scarf.SetActive (value);
	}
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
		scarf.SetActive (false);
		partyHat.SetActive (false);
		charmander.SetActive (false);
	}
		

	public void pikachuAppear(bool value){
		pikachu.SetActive (value);
	}
	public void charmanderAppear(bool value){
		charmander.SetActive (value);
	}

}
