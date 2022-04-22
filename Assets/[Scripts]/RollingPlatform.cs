using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingPlatform : MonoBehaviour
{
    
    public bool isPlayer;
    //public bool isWall;
    //public BoxCollider2D right;
    //public BoxCollider2D left;

    void Start()
    {        
        isPlayer = false;
        //isWall = false;
    }

     public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayer = true;
            other.gameObject.transform.SetParent(this.transform);
        }
        /*if(other.gameObject.CompareTag("Ground"))
        {
            isWall = true;
        }*/
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayer = false;
            other.gameObject.transform.SetParent(null);
        }
        /*if(other.gameObject.CompareTag("Ground"))
        {
            isWall = false;
        }*/
    }
}
