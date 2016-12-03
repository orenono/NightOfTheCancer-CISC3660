﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HighScore : MonoBehaviour {

	const int NUM_SCORES = 5;

	public Text[] nameTxts;
	public Text[] scoreTxts;

	// Use this for initialization
	void Start () {
		string nameKey = "HighScoreName";
		string scoreKey = "HighScore";

		for (int i = 0; i < NUM_SCORES; i++)
		{
			nameTxts[i].text = PlayerPrefs.GetString ("HighScoreName"+i);
			scoreTxts[i].text = PlayerPrefs.GetInt ("HighScore" + i).ToString();
		}

	}

	public void returnToMain () {
		SceneManager.LoadScene ("startMenu");
	}
}
