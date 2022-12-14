using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backgrounds : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray = new Sprite[6];
    public static Backgrounds instance;
    public int background;
   
    
    Color32 color;
    void Awake(){
        instance = this;
        background = PlayerPrefs.GetInt("Background",0);
        spriteRenderer.sprite = spriteArray[background];
        
        spriteRenderer.transform.localScale = new Vector3(1.5f,1.5f,1.5f);
        switch(background){
            case 0:
                spriteRenderer.color = new Color32(255,255,255,255);
                break;
            case 1:
                spriteRenderer.color = new Color32(121, 0, 0, 255);
                break;
            case 2:
                spriteRenderer.color = new Color32(222, 62, 166, 255);
                break;
            case 3:
                spriteRenderer.color = new Color32(0, 0, 108, 255);
                break;
            case 4: 
                spriteRenderer.color = new Color32(255,255,255,255);
                break;

        }
    } 
}
