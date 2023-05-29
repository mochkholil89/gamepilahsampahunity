using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour {
	public Text textScore;

	// Use this for initialization
	private void OnTriggerEnter2D(Collider2D collision)
	{
		Destroy(collision.gameObject);
		SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
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
}
