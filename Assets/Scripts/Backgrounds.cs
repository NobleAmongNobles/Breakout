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
    } 
}
