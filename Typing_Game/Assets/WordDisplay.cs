using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour {

	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
	}
	public void RemoveLetter()
	{
		text.text = text.text.Remove(0,1);
		text.color = Color.red;
	}
	public void RemoveWord()
	{
		Destroy(gameObject);
	}

		void Update()
	{
		transform.Translate(0f,-fallSpeed * Time.deltaTime,0f);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "GameOver")
		{
			Debug.Log("Hit");
			Time.timeScale = 0;
		}
		
	}

}
