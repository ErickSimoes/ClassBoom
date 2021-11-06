using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveVariables : MonoBehaviour
{
    public int player1SkinIndex, player2SkinIndex;
    void Awake() {
        debugar();
        DontDestroyOnLoad(this.gameObject);
    }

    public void debugar() {
        print("p1 index: " + player1SkinIndex + "p2 index: " + player2SkinIndex);
    }
}
