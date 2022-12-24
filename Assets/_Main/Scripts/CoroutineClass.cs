using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineClass : MonoBehaviour {

	private int counter=0;

	// Use this for initialization
	void Start () {
		StartCoroutine("SampleRoutine");
		//StopCoroutine("SampleRoutine");
	}

	IEnumerator SampleRoutine()
    {
		counter++;
		Debug.Log("Routine Started "+counter);
		yield return null;
		Debug.Log("Skipped 1 frame");
		yield return new WaitForSeconds(1f);
		Debug.Log("Skipped 1 second and ended");
		//yield break //to exit a routine
	}
}
