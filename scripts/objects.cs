using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour {
	public Color col;
	public static float SPEED = .1f;
	public float xspeed;
	public float yspeed;
	public float zspeed;
	float elapsedTime;

	void Start () {
		xspeed = Random.Range( -SPEED, SPEED );
		yspeed = Random.Range( -SPEED, SPEED );
		zspeed = Random.Range (-SPEED, SPEED);
		col = RandomColor();
		SetColor ();
		Debug.Log (xspeed);
	}

	void Update () {
		elapsedTime += Time.deltaTime;
		transform.position += new Vector3(
			xspeed * Time.deltaTime, 
			yspeed * Time.deltaTime, 
			zspeed * Time.deltaTime
		);

		transform.Rotate(Vector3.right * Time.deltaTime);
		transform.Rotate(Vector3.up * Time.deltaTime);

		if (elapsedTime >= 2)
		{
			elapsedTime = 0;
			col = RandomColor();
			SetColor ();
		}
	}

	void SetColor () {
		GameObject[] boxes = GameObject.FindGameObjectsWithTag("Player");
		GameObject[] lights = GameObject.FindGameObjectsWithTag("lightSource");
		if (lights.Length != 0) {
			for (int i = 0; i < lights.Length; i++) {
				Light li = lights [i].GetComponent<Light> () as Light;
				li.color = col;
			}
		}
		if (boxes.Length != 0) {
			for (int i = 0; i < boxes.Length; i++) {
				Renderer rend = boxes [i].GetComponent<Renderer> () as Renderer;
				rend.material.color = col;
			}
		}
	}

	Color RandomColor() {
		return new Color(Random.value, Random.value, Random.value);
	}
}
