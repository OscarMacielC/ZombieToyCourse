using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour {

	[SerializeField] private Transform _target = null;
	[SerializeField] private NavMeshAgent agent = null;
	[SerializeField] private float _updateDelay = 3f;

	void Reset()
    {
		agent = GetComponent<NavMeshAgent>();
    }

	void Start()
    {
		InvokeRepeating("FollowTarget",0f,_updateDelay);
    }

	void FollowTarget()
    {
		agent.SetDestination(_target.position);
    }

}
