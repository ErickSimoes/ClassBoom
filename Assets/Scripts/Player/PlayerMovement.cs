using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerBehaviour _playerBehaviour;

    [Header("Movement")]
    [Range(100,300)]
    [SerializeField] float speed = 100;
    Vector2 direction;

    void Update() {
        direction = _playerBehaviour.direction;
        _playerBehaviour.rb.velocity = direction.normalized * speed * Time.fixedDeltaTime;
    }
}
