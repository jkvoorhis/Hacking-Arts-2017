using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setUp : MonoBehaviour {
	public GameObject cubePrefab;

	void Start () {
		Vector3 camPos = Camera.main.transform.position;
		for (int i = 0; i < 15; i++) {
			Instantiate (
				cubePrefab, 
				new Vector3(
					camPos.x + Random.Range( -25.0f, 25.0f ), 
					camPos.y + Random.Range( -25.0f, 25.0f ), 
					camPos.z + Random.Range( -25.0f, 25.0f )
				),
				Quaternion.identity
			);
		}
	}

	void Update () {
		
	}
}

