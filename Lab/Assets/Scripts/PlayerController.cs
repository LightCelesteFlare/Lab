using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rbody;
    public float speed = 5;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float horzin = Input.GetAxis("Horizontal");
        float vertal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horzin * speed, vertal * speed, 0);
        rbody.velocity = movement;

        Debug.Log("h =" + horzin + "v =" + vertal);


    }
 
}
