using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hairetu_kadai : MonoBehaviour
{
    void Start()
    {
        int[] array = { 15, 30, 45, 60, 75 };
        for (int cnt = 0; cnt < 5; cnt++)
        {
            Debug.Log(array[cnt] );
        }
    }
}