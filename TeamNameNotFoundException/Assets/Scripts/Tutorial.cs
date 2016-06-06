using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour {

    private int currentImage;
    public Image[] images;
	// Use this for initialization
	void Start () {
        currentImage = 0;
        setImageFalse();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            setImageFalse();
        }
    }

    private void setImageFalse()
    {
        if(currentImage == images.Length)
        {
           SceneManager.LoadScene("CharacterSelection");
        }
        foreach (Image im in images)
        {
            im.enabled = false;
        }
        if (currentImage < images.Length)
        {
            images[currentImage].enabled = true;
            currentImage++;
        }
    }
}
