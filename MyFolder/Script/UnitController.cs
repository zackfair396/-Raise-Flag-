using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BowControlar : MonoBehaviour
{
    GameObject Bow;
    //メソッド作成


    // Start is called before the first frame update
    void Start()
    {
        this.Bow = GameObject.Find("Bow");
        //ゲームオブジェクトのBowと繋げる
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Bow = Selection.activeGameObject;
        }    
            //Bowにマウスクリックされた時、Bowを選択状態にする。
    }
}
