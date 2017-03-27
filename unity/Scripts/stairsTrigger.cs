using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairsTrigger : MonoBehaviour {
	public Transform StairsPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider yayother) {
		Instantiate(StairsPrefab, new Vector3(-183, transform.parent.position.y + 20f, transform.parent.position.z + 40), StairsPrefab.rotation);

		transform.parent.gameObject.AddComponent<TimeToDestroy> ();
	}
}
