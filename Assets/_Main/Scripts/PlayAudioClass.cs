using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClass : MonoBehaviour {

	[SerializeField] private AudioSource _audioSrc;
	[SerializeField] private AudioClip _audioClp;

	// Use this for initialization
	void Start () {
		_audioSrc.clip = _audioClp;
	}

	void Reset()
	{
		_audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
			_audioSrc.Play();
        }
	}
}
