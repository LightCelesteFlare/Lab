using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    private Transform camTrans;

	// Use this for initialization
	void Start () {
        camTrans = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        camTrans.position = new Vector3(player.position.x, player.position.y, camTrans.position.z);
	}


}
