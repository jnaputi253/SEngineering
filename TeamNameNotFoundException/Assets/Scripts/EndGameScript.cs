using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndGameScript : MonoBehaviour {
	public AudioClip menuSelect;
	public GameObject soundManager;

	void Start() {
		if(SoundManager.instance == null) {
			Instantiate (soundManager);
		}

		SoundManager.instance.musicSource.Play ();
	}

	public void Restart() {
		SoundManager.instance.PlaySingle (menuSelect);
		SceneManager.LoadScene ("MenuScene");
	}

	public void Exit() {
		SoundManager.instance.PlaySingle (menuSelect);
		Application.Quit ();
	}
}
