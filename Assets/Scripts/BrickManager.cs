using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{   public static BrickManager instance;
    public int rows;
    public int columns;
    public float spacing;
    public GameObject Brick1;
    public GameObject Brick2;
    public GameObject Brick3;
    public GameObject Brick4;
    public int pointsBrick1 = 10;
    public int pointsBrick2 = 20;
    public int pointsBrick3 = 30;
    public int pointsBrick4 = 40;

    private List<GameObject> bricks = new List<GameObject>();
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
                if(randomnumber == 0){
                    Vector2 spawnPos = (Vector2)transform.position + new Vector2
                    (
                        x * (Brick1.transform.localScale.x + spacing),
                        -y * (Brick1.transform.localScale.y + spacing)
                    );
                    GameObject brick = Instantiate(Brick1, spawnPos, Quaternion.identity);
                    bricks.Add(brick);
                }
                if (randomnumber == 1){
                    Vector2 spawnPos = (Vector2)transform.position + new Vector2
                    (
                        x * (Brick2.transform.localScale.x + spacing),
                        -y * (Brick2.transform.localScale.y + spacing)
                    );
                    GameObject brick = Instantiate(Brick2, spawnPos, Quaternion.identity);
                    bricks.Add(brick);
                } 
                if(randomnumber == 2){
                    Vector2 spawnPos = (Vector2)transform.position + new Vector2
                    (
                        x * (Brick3.transform.localScale.x + spacing),
                        -y * (Brick3.transform.localScale.y + spacing)
                    );
                    GameObject brick = Instantiate(Brick3, spawnPos, Quaternion.identity);
                    bricks.Add(brick);
                }
                if(randomnumber == 3){
                    Vector2 spawnPos = (Vector2)transform.position + new Vector2
                    (
                        x * (Brick4.transform.localScale.x + spacing),
                        -y * (Brick4.transform.localScale.y + spacing)
                    );
                    GameObject brick = Instantiate(Brick4, spawnPos, Quaternion.identity);
                    bricks.Add(brick);
                }
            }
        }
    }
}
