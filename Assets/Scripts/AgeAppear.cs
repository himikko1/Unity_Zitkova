using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AgeAppear : MonoBehaviour {

	public GameObject inputField2; // Здесь мы объявляем переменную inputField2 типа InputField, чтобы получить доступ к полю ввода
	public GameObject ageAppear; // Здесь мы объявляем переменную ageAppear типа Text, чтобы вывести на экран возраст

	public void saveTextOfAge(){
		int age;
		if (int.TryParse(inputField2.text2, out age)) { // Здесь мы проверяем, что пользователь ввел число
			ageAppear.text2 = age + " years old!"; // Здесь мы выводим возраст на экран
		} else {
			Debug.Log("Ошибка ввода. Введите число."); // Здесь мы выводим сообщение об ошибке в консоль Unity
		}
	}

	private void Start() {
		inputField2.contentType = InputField.ContentType.IntegerNumber; // Здесь мы устанавливаем тип контента поля ввода на "целое число"
	}
}