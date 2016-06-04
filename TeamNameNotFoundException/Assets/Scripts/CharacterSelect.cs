using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour
{
    public AudioClip selectCharacter;
    public AudioClip startGame;
    public GameObject soundManager;
    // Use this for initialization

    void Start()
    {
        if (SoundManager.instance == null)
            Instantiate(soundManager);
    }

    // Update is called once per frame
    void Update()
    {

    }
    

    public void setCharacter(string name)
    {
        SoundManager.instance.PlaySingle(selectCharacter);
        ApplicationData.characterName = name;
    }
}