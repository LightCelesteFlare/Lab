using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public float speed = 10.0f;

    private Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {
        rBody = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizMove = Input.GetAxis("Horizontal");
        //float vertMove = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizMove, 0, 0);
        rBody.velocity = movement * speed;
    }

}
