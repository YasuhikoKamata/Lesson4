using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kansu02 : MonoBehaviour {

    //第一引数と、第2引数の値を返す関数
   int Uma(int a, int b, int c)
    {
        //第一引数と、第2引数の値を足して、変数cに代入する。
        int Jin = a + b * c;
        return Jin;
    }
    void Start()
    {
        //Add関数に３，６の引数を渡し、返り値をnumに代入
        int num = Uma (3, 6, 8);
        //numを表示
        Debug.Log(num);
    }
	void Update () {
	}
}