using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {
	//private Vector3 screenPoint;
	//private Vector3 offset;
	//private float firstY;

	void OnMouseDown()
	{
		//firstY = transform.position.y;
		//screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		//offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
		SceneManager.LoadScene("Level1", LoadSceneMode.Single);
	}
}
