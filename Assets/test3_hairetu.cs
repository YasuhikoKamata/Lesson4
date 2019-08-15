using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3_hairetu : MonoBehaviour {

	void Start () {

        int[] points = new int[3]; //要素数5の配列を初期化する

        //配列の各要素に値を代入
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        
      //配列の要素を表示する。
        for (int i=0; i < 3; i++)
        {
            Debug.Log(points[i]);
        }
    }

	void Update () {
	}
}
