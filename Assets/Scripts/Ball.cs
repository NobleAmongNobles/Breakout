using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public static Ball instance;
    public float speed = 7f;

    private void Awake(){
        instance = this;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        yield return new WaitForSeconds(3);
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = speed * (GetComponent<Rigidbody2D>().velocity.normalized);
        float ratio = GetComponent<Rigidbody2D>().velocity.x / GetComponent<Rigidbody2D>().velocity.y;
        if(ratio > 25 || ratio < -25){
            if(GetComponent<Rigidbody2D>().velocity.y > 0){
                GetComponent<Rigidbody2D>().velocity += new Vector2(0,1f);
            }
            else{
                GetComponent<Rigidbody2D>().velocity -= new Vector2(0,1f);
            }
        }
    }
}
