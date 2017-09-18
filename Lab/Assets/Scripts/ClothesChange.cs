using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClothesChange : MonoBehaviour {
    public Sprite clothes1;
    public Sprite clothes2;
    public Sprite clothes3;

    static public int Num;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = clothes1; // set the sprite to sprite1
    }

    void Update()
    {

            ChangeSprite(); // call method to change sprite
   
    }

    void ChangeSprite()
    {
        
        if ( Num == 1)
        {
            spriteRenderer.sprite = clothes1;
        }
        else if(Num == 2)
        {
            spriteRenderer.sprite = clothes2;
        }
        else if ( Num == 3)
        {
            spriteRenderer.sprite = clothes3;
        }
    }
}
