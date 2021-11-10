using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStorer : MonoBehaviour
{
    public void callStorerDestroyer(){
        StorerBehaviour.instance.DestroyStorer();
    }
}
