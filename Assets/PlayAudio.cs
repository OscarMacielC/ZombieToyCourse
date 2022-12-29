using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

	[SerializeField] private AudioClip _sonidoArma1;
	[SerializeField] private AudioSource _audioSource=null;

	// Use this for initialization
	void Reset () {
		_audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
