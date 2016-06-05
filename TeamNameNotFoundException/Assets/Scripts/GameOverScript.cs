using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	public void PlayAgain() {
		SceneManager.LoadScene ("CharacterSelection");
	}

	public void Exit() {
		Application.Quit ();
	}
}
