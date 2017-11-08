using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
	public float speed;
	
	// Update is called once per frame
	void Update ()
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime * speed);
	}
}
