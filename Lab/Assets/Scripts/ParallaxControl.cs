using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxControl : MonoBehaviour {

    public float parallaxSpeed;
    private Transform mainCameraTrans;
	// Use this for initialization
	void Start () {
        mainCameraTrans = Camera.main.transform;	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(this.transform.position.z, this.transform.position.y, this.transform.position.z) * parallaxSpeed;
	}
}
