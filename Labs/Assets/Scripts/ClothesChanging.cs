using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothesChanging : MonoBehaviour {

    public Sprite[] s1;
    public Button b1;
    public Button b2;
    public Button b3;

    public int count = 0;
    void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("Sprites");
    }

    public void On_Click_Button()
    {
        if (b1)
        {
            count = 1;
        }
        else if (b2)
        {
            count = 2;
        }
        else if (b3)
        {
            count = 3;
        }
        b1.image.sprite = s1[count];
    }
}
