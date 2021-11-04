using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] PlayerBehaviour _playerBehaviour;

    void Update() {
        anim.SetFloat("xVelocity", Mathf.Abs(_playerBehaviour.direction.x));
        anim.SetFloat("yVelocity", _playerBehaviour.direction.y);
        anim.SetFloat("speed", _playerBehaviour.direction.SqrMagnitude());

    }
}
