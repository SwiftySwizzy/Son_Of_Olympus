using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

	public void Play(){
		SceneManager.LoadScene ("main_scene");
	}

	public void Shop() {
	
	}

	public void Exit () {

	}

	public void SetMusicVolume(float value) {
	}
}
