﻿using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour 
{
	public AudioSource efxSource;
    public AudioSource sfxSournce;
    public AudioSource musicSource;
    public AudioSource bossBGM;
    public AudioSource thunder;
	public static SoundManager instance = null;					
	public float lowPitchRange = .95f;				
	public float highPitchRange = 1.05f;			
		
	void Awake ()
	{
		if (instance == null)
        {
            instance = this;
        }
		else if (instance != this)
        {
            Destroy(gameObject);
        }
		DontDestroyOnLoad (gameObject);
	}
		
	public void PlaySingle(AudioClip clip, bool isGirl = false)
	{
		efxSource.clip = clip;
        if (isGirl)
            efxSource.pitch = 1.5f;
		efxSource.Play();
	}
		
	public void RandomizeSfx (params AudioClip[] clips)
	{
		int randomIndex = Random.Range(0, clips.Length);
		float randomPitch = Random.Range(lowPitchRange, highPitchRange);
		efxSource.pitch = randomPitch;
		efxSource.clip = clips[randomIndex];
		efxSource.Play();
	}

    public void RSfx(params AudioClip[] clips)
    {
        int index = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        sfxSournce.pitch = randomPitch;
        sfxSournce.clip = clips[index];
        sfxSournce.Play();
    }
    
}
