using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeteksiSampah : MonoBehaviour {
	public string nameTag;
	public AudioClip audioBenar;
	public AudioClip audioSalah;
	private AudioSource MediaPlayerBenar;
	private AudioSource MediaPlayerSalah;
	public Text textScore;
	Scene m_scene;
	string sceneName;
	//public string

	// Use this for initialization
	private void Start()
	{
		MediaPlayerBenar = gameObject.AddComponent<AudioSource>();
		MediaPlayerBenar.clip = audioBenar;
		textScore.text = Data.score.ToString();
		MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
		MediaPlayerSalah.clip = audioSalah;
		//textScore.GetComponent<RectTransform>().localPosition = new Vector3(0, -40, 0);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag.Equals(nameTag))
		{
			m_scene = SceneManager.GetActiveScene ();
			sceneName = m_scene.name;
			Data.score += 10;
			textScore.text = Data.score.ToString();
			Destroy(collision.gameObject);
			MediaPlayerBenar.Play();
			if (Data.score >= 100 && sceneName == "Level1") {
				MediaPlayerBenar.Stop();
				SceneManager.LoadScene ("Level2");
			} else if (Data.score >= 200 && sceneName == "Level2") {
				MediaPlayerBenar.Stop();
				SceneManager.LoadScene ("Level3");
			}
			else if (Data.score >= 300 && sceneName == "Level3") {
				MediaPlayerBenar.Stop();
				SceneManager.LoadScene ("Level4");
			}
			else if (Data.score >= 500 && sceneName == "Level4") {
				MediaPlayerBenar.Stop();
				SceneManager.LoadScene ("GameWin");
			}
		}
		else
		{
			Data.score -= 5;
			MediaPlayerSalah.Play();
			if (Data.score <= 0) {
				
				textScore.color = Color.red;
				textScore.GetComponent<RectTransform> ().sizeDelta = new Vector2 (400, 100);
				textScore.GetComponent<RectTransform>().localPosition = new Vector3(0, -30, 0);
				//textScore.text = "Score : " +Data.score.ToString();
				Data.score = 0;
				textScore.text = "Score : " + Data.score.ToString ();
				SceneManager.LoadScene("Gameover", LoadSceneMode.Single);
				//Data.score = 0;
			} 
			else {
				textScore.text = Data.score.ToString();
				Destroy(collision.gameObject);
			}
		}
	}
}
