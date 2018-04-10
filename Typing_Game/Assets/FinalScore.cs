using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class FinalScore : MonoBehaviour {

	private TextMeshProUGUI scoreText;
	//WordManager wordManager;
	// Use this for initialization
	void Start () {
		scoreText = GetComponent<TextMeshProUGUI>();
        
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.SetText("Score: {0}", WordManager.score);
		if(Input.GetKey(KeyCode.Space))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
		}
	}
}
