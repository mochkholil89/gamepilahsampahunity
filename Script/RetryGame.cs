using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown()
	{
		//firstY = transform.position.y;
		//screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		//offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		SceneManager.LoadScene("GameMulai", LoadSceneMode.Single);
	}
}
