using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {

	void Update () {
		
	}
	public string text;
	public GameObject inputField;
	public GameObject textAppear;
	public void saveText(){
		text = inputField.GetComponent<Text> ().text;
		textAppear.GetComponent<Text>().text = "Hey" +text.ToUpper()+"!";
	}

}
