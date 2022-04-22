using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topes : MonoBehaviour
{
    public bool isWall;
    // Start is called before the first frame update
    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
           isWall = true; 
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isWall = false;
        }
    }
}
