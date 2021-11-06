using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseSkinController : MonoBehaviour{
    //KeyCodes
    [SerializeField] KeyCode leftArrow, rightArrow;

    //Checkers
    [SerializeField] int clickQuantity;
    public int skinIndex;

    //flags 
    [SerializeField] bool canMoveArrow;
    public bool selected;

    //Objects
    [SerializeField] GameObject[] skins;
    [SerializeField] GameObject opaquePanel, okPanel;
    void Update() {
        if(Input.GetKeyDown(leftArrow)) {
            if(skinIndex > 0 && canMoveArrow) {
                skinIndex--;
                changeSkin();
            }
        } else if(Input.GetKeyDown(rightArrow)) {
            if(skinIndex < 3 && canMoveArrow) {
                skinIndex++;
                changeSkin();
            }
        }
    }
    
    void changeSkin() {
        for (int i = 0; i < skins.Length; i++) {
            if(i == skinIndex) {
                skins[i].SetActive(true);
            } else {
                skins[i].SetActive(false);
            }
        }
    }
    public void ShowSkinCanvas() {
        clickQuantity++;
        if(clickQuantity > 1) {
            okPanel.SetActive(true);
            canMoveArrow = false;
            selected = true;
        } else {
            opaquePanel.SetActive(false);
            canMoveArrow = true;
        }
    }
}
