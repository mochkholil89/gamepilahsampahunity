using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {
	public Text textScore;
	// Use this for initialization
	void Start () {
		textScore.color = Color.white;
		textScore.GetComponent<RectTransform> ().sizeDelta = new Vector2 (400, 100);
		textScore.GetComponent<RectTransform>().localPosition = new Vector3(0, -30, 0);

		if (Data.score <= 0) {
			Data.score = 0;
			textScore.text = "Score : " + Data.score.ToString ();
		} else {
			textScore.text = "Score : " + Data.score.ToString ();
			Data.score = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
