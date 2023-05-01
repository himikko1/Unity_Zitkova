using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeAppear : MonoBehaviour {

	void Update () {

	}
	public GameObject text;
	public GameObject inputAge;
	public void showTextAge(){
		text.GetComponent<Text> ().text=
			"I am "+ inputAge.GetComponent<Text>().text+" years old!";
	}

}