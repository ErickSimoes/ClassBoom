using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    [SerializeField] string[] inputNames;
    [SerializeField] string lauchButtonName = "Launch";
    public Vector2 movingInputs;
    [SerializeField] PlayerBehaviour _playerBehaviour;
    
    void Update() {
        movingInputs.x = Input.GetAxisRaw(inputNames[0]);
        movingInputs.y = Input.GetAxisRaw(inputNames[1]);

        if(Input.GetButtonDown(lauchButtonName))
            _playerBehaviour._bombController.LauchBomb();
    }
}
