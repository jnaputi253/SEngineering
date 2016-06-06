using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

    private int currentImage;
    public Image[] images;
    public string scene;
    private bool animationPlayed = false;
    public GameObject vortex;
    public GameObject soundManager;
    public AudioClip thunder;
    // Use this for initialization
    void Start()
    {
        if (SoundManager.instance == null)
            Instantiate(soundManager);
        if(scene == "TestScene")
        {
            SoundManager.instance.thunder.Play();
        }
        currentImage = 0;
        switchImages();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            switchImages();
        }
    }

    private void switchImages()
    {
        if(currentImage == images.Length)
        {
           if(scene == "TestScene" && !animationPlayed)
            {
                hideAllImages();
                Instantiate(vortex);
                animationPlayed = true;
                SoundManager.instance.PlaySingle(thunder);
            }
            else
            {
                SoundManager.instance.thunder.Stop();
                SceneManager.LoadScene(scene);
            }
        }
        else
        {
            hideAllImages();
            if (currentImage < images.Length)
            {
                images[currentImage].enabled = true;
                currentImage++;
            }
        }
    }

    private void hideAllImages()
    {
        foreach (Image im in images)
        {
            im.enabled = false;
        }
    }
}
