using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

    //public Button myButton;
    public int Num;
	// Use this for initialization
	void Start () {
        //Button btn = myButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    //void TaskOnClick()
    //{
    //    Debug.Log("you have clicked the button!");
    //    Num = 0;
    //}

    void OnMouseDown()
    {
        ClothesChange.Num = Num;
        Debug.Log("Sprite Clicked");
    }
}
