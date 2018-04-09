using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginButton : MonoBehaviour {

	public WordManager wordManager;
	// Use this for initialization
	void Start () {
		wordManager = GetComponent<WordManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Mouse0))
		{
			wordManager.begin = true;
			//Destroy(gameObject);
		}
	}

}
