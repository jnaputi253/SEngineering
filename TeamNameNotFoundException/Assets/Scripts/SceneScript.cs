using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {
    public AudioClip menuSelect;
    public GameObject soundManager;
	// Use this for initialization
	void Start () {
        if (SoundManager.instance == null)
            Instantiate(soundManager);
        SoundManager.instance.musicSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void goToCharacterSelectionScreen()
    {
        SoundManager.instance.PlaySingle(menuSelect);
        SceneManager.LoadScene("CharacterSelection");
    }

    public void goToGameScene()
    {
        SoundManager.instance.PlaySingle(menuSelect);
        SceneManager.LoadScene("MainScene");
    }

    public void goToTutorialScene()
    {
        SoundManager.instance.PlaySingle(menuSelect);
        SceneManager.LoadScene("TutorialScene");
    }

    public void exitGame()
    {
        SoundManager.instance.PlaySingle(menuSelect);
        Application.Quit();
    }
}
