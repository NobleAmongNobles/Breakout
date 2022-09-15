using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{   
    public static BrickManager instance;
    public int rows;
    public int columns;
    public float spacing;
    public GameObject Brick1;
    public GameObject Brick2;
    public GameObject Brick3;
    public GameObject Brick4;
    public int pointsBrick1Player1 = 10;
    public int pointsBrick2Player1 = 20;
    public int pointsBrick3Player1 = 30;
    public int pointsBrick4Player1 = 40;
    public int pointsBrick1Player2 = 10;
    public int pointsBrick2Player2 = 20;
    public int pointsBrick3Player2 = 30;
    public int pointsBrick4Player2 = 40;

    public List<GameObject> bricks = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake(){
        instance = this;
    }

    public void ResetLevel(){
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();
        System.Random itemgenerator = new System.Random();
        for(int x = 0; x < columns; x++){
            for(int y = 0; y < rows; y++){
                int randomnumber = itemgenerator.Next(4);
                GameObject prefab;
                switch(randomnumber){
                    case 0:
                        prefab = Brick1;
                        break;
                    case 1:
                        prefab = Brick2;
                        break;
                    case 2:
                        prefab = Brick2;
                        break;
                    case 3:
                        prefab = Brick4;
                        break;
                }
                Vector2 spawnPos = (Vector2)transform.position + new Vector2
                (
                    x * (prefab.transform.localScale.x + spacing),
                    -y * (prefab.transform.localScale.y + spacing)
                );
                GameObject brick = Instantiate(prefab, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }
}
