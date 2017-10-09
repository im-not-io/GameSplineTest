using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void SplineMove() {
		Debug.Log ("spline move triggered");
		LTSpline ltSpline = new LTSpline( new Vector3[] { new Vector3(0f,0f,0f),new Vector3(0f,0f,0f), new Vector3(3f,3f,0f), new Vector3(10f,0f,0f), new Vector3(0f,0f,0f), new Vector3(0f,0f,0f)} );
		LeanTween.moveSpline(gameObject, ltSpline, 4.0f).setOrientToPath(true).setDelay(1f); // animate 
		Vector3 pt = ltSpline.point( 0.6f ); // retrieve a point along the path
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("left click trigger");
			SplineMove ();
		}
	}


}
