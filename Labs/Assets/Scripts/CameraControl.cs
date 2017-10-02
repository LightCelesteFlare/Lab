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
    public float smooth = 0.2f;
    private float maxSize = 7f;
    private float minSize = 2f;
    
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
            Debug.Log("YOU Enter 1");
        }
        else if(mode == 2)
        {
        camTrans.position = new Vector3(FixView.position.x, FixView.position.y, camTrans.position.z);
            size = 7;
            
                Camera.main.orthographicSize = size;
            Debug.Log("YOU Enter 2");
        }
        else if (mode == 3)
        {
            camTrans.position = new Vector3(playerPosition.position.x, playerPosition.position.y, camTrans.position.z);
            
            if (size != 0)
            {
                if(Input.GetKey("a"))
                {
                    Camera.main.orthographicSize += smooth;
                }
                if(Input.GetKey("d"))
                {
                    Camera.main.orthographicSize -= smooth;
                }
                Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minSize, maxSize);
            }
            Debug.Log("YOU Enter 3");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Trigger")
        {
            mode = 1;
            
        }
        else if (other.gameObject.name == "Trigger2")

        {
            mode = 2;
            
        }
        else if (other.gameObject.tag == "Trigger3")
        {
            mode = 3;
            
        }
    }

}
