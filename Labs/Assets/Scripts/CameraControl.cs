using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform playerPosition;
    public Transform FixView;
    public Transform ZoomView;

    private Transform camTrans;
    public int size = 2;
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
            for (int i = 1; size > 2; i--)
            {
                Camera.main.orthographicSize = size - i;
            }
        }
        else if(mode == 2)
        {
        camTrans.position = new Vector3(FixView.position.x, FixView.position.y, camTrans.position.z);
            for (int i = 1; size > 9; i++)
            {
                Camera.main.orthographicSize = size + i;
            }
        }
        //else if (mode == 3)
        //{

        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Trigger1")
        {
            mode = 1;
        }
        else if (other.name == "Trigger2")
        {
            mode = 2;
        }
        else if (other.tag == "Person")
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
