using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerrisWheelPlatform : MonoBehaviour
{
    [Header("Movement")]
    public float horizontalForce;
    public float verticalForce;
    public Transform[] pos;

    private Rigidbody2D _rigidBody2D;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        transform.position = pos[0].position;
    }

    void Update()
    {
        Vector2 move;
        if(transform.position.x > pos[1].position.x && transform.position.y < pos[1].position.y)
        {
            move = new Vector2(-horizontalForce, verticalForce);
            _rigidBody2D.AddForce(move);
        }
        else if(transform.position.x < pos[2].position.x && transform.position.y < pos[2].position.y)
        {
            move = new Vector2(horizontalForce, verticalForce);
            _rigidBody2D.AddForce(move);
        }
        else if(transform.position.x < pos[3].position.x && transform.position.y > pos[3].position.y)
        {
            move = new Vector2(horizontalForce, verticalForce);
            _rigidBody2D.AddForce(move);
        }
        else if(transform.position.x > pos[0].position.x && transform.position.y > pos[0].position.y)
        {
            move = new Vector2(-horizontalForce, verticalForce);
            _rigidBody2D.AddForce(move);
        }
        
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(this.transform);
        }
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(null);
        }
    }
}
