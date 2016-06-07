using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndGameScript : MonoBehaviour {

	public void Restart() {
		SceneManager.LoadScene ("CharacterSelection");
	}

	public void Exit() {
		Application.Quit ();
	}
}
