using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	public float Dx;
	public float Dy;
	public float Dz;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (Dx, Dy, Dz);
	}
}
