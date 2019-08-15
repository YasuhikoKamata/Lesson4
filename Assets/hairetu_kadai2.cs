using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu_kadai2 : MonoBehaviour
{
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        for (int cnt = 4; cnt >= 0; cnt--)
        {
            Debug.Log(array[cnt]);
        }
    }
}