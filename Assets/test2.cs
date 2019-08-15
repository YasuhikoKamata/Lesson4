using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {

	void Start () {
	    int money = 100; //moneyを100で初期化する
        if (money <= 50){
            Debug.Log("武器を売る"); //moneyが50以下の処理

        } else if(money >= 200){
            Debug.Log("武器を買う"); //moneyが200以上の処理

        } else {
            Debug.Log("ポーションを買う");//それ以外の処理
        }
   	}
	void Update () {
	}
}
