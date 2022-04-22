using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingPlatform : MonoBehaviour
{
    private Rigidbody2D _rigidBody2D;
    public Animator _animator;

    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _animator.SetBool("collapse", true);
            Invoke("CollapsePlatform", 1.0f);
            Destroy(gameObject, 2.5f);
        }
    }

    void CollapsePlatform()
    {
        _rigidBody2D.isKinematic = false;
    }
}
