using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject Player;
    public Transform playerPosition;
    public Transform FixView;
    public Transform ZoomView;

    private Transform camTrans;
    public float size = 2f;
    public float smooth = 0.3f;
    public int mode = 1;
    // Use this for initialization
    void Start()
    {
        camTrans = this.transform;
    }

    //Update is called once per frame
    void Update()
    {
        if (mode == 1) {
        camTrans.position = new Vector3(playerPosition.position.x, playerPosition.position.y, camTrans.position.z);
            size = 2;
                Camera.main.orthographicSize = size;
            
        }
        else if(mode == 2)
        {
        camTrans.position = new Vector3(FixView.position.x, FixView.position.y, camTrans.position.z);
            size = 7;
            
                Camera.main.orthographicSize = size;

        }
        //else if (mode == 3)
        //{

        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            mode = 1;
        }
        else if (other.gameObject.tag == "Player")
        {
            mode = 2;
        }
        else if (other.gameObject.tag == "Screen3")
        {
            //if(Input.GetKey("d"))
            //{
            //    camTrans.position = new Vector3();
            //}
            //else if(Input.GetKey("a"))
            //{

            //}
        }
    }

}
