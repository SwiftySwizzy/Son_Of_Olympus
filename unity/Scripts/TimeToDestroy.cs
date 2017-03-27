using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour {
	public float destroyTime = 15f;
	private float currTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currTime += Time.deltaTime;

		if (currTime > destroyTime) {
			Destroy (gameObject);
		}
	}
}
