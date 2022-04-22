using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crank : MonoBehaviour
{
    public Sprite down;
    public Sprite up;
    private SpriteRenderer _sprite;    
    public bool isUp;
    public bool interact;
    public MovingPlatformController mpC;

    void Start()
    {
       _sprite = GetComponent<SpriteRenderer>();
       isUp = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            interact = true;
        }
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (interact && other.gameObject.CompareTag("Player") && !isUp)
        {
            _sprite.sprite = up;
            mpC.direction = PlatformDirection.VERTICAL;
            isUp = true;
            interact = false;
        }
        else if (interact && other.gameObject.CompareTag("Player") && isUp)
        {
            _sprite.sprite = down;
            mpC.direction = PlatformDirection.HORIZONTAL;
            isUp = false;
            interact = false;
        }
    }
}
