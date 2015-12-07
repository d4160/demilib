﻿using UnityEngine;
using System.Collections;
using DG.DeAudio;

public class DeAudioNoManagerExampleBrain : MonoBehaviour
{
	[Header("Settings")]
	public bool usePrefab;
	public string prefabName = "- DeAudioManager";
	[Header("FX")]
    public DeAudioClipData fxA;
    public DeAudioClipData fxB;
    [Header("MUSIC")]
    public DeAudioClipData musicA;
    public DeAudioClipData musicB;

    void Start()
    {
    	if (usePrefab) {
    		// Instantiate existing prefab from Resources folder
    		DeAudioManager.Init(prefabName);
    	} else {
    		// Create a new DeAudioManager
    		DeAudioManager.Init();
    	}
    }

    public void PlayFXA()
    {
        DeAudioManager.Play(fxA);
    }

    public void PlayFXB()
    {
        DeAudioManager.Play(fxB);
    }

    public void PlayMusicA()
    {
        DeAudioManager.Play(musicA);
    }

    public void PlayMusicB()
    {
        DeAudioManager.Play(musicB);
    }

    public void StopAll()
    {
        DeAudioManager.Stop();
    }

    public void StopAllMusic()
    {
        DeAudioManager.Stop(DeAudioGroupId.Music);
    }

    public void StopMusicA()
    {
        DeAudioManager.Stop(musicA.clip);
    }

    public void FadeOutGlobal()
    {
    	DeAudioManager.FadeOut();
    }

    public void FadeOutMusic()
    {
    	DeAudioManager.FadeOut(DeAudioGroupId.Music);
    }

    public void FadeOutMusicA()
    {
    	DeAudioManager.FadeOut(musicA.clip);
    }

    public void FadeInGlobal()
    {
    	DeAudioManager.FadeIn();
    }

    public void FadeInMusic()
    {
    	DeAudioManager.FadeIn(DeAudioGroupId.Music);
    }

    public void FadeInMusicA()
    {
    	DeAudioManager.FadeIn(musicA);
    }

    public void CrossfadeMusicToB()
    {
        DeAudioManager.Crossfade(musicB);
    }
}