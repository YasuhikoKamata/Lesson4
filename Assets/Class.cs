using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
    private int hp = 100;   //体力
    private int power = 25; //攻撃力
    private int mp = 53;    //魔力

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！！");
    }
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りのHPを減らす。
        this.hp -= damage;
    }
    //魔法攻撃用の関数
    public void Magic(int maho)
    {
        this.mp -= maho;//残りのMPを減らす。
   
        if (mp >= 0)
        {
        Debug.Log("魔法攻撃をした！残りMPは" + this.mp);
        }
        else{
        Debug.Log("mpが足りない！");
        }
    } 
}
public class Class : MonoBehaviour
{
   void Start()
    {
        //Bossクラスの関数を宣言して、インスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す。
        lastboss.Attack();

        //防御用の関数を呼び出す。
        lastboss.Defence(3);

        //魔法用の関数を呼び出す。
        for (int mp = 10; mp >= 0; mp--)
        { 
        lastboss.Magic(5);
    }
  }
}
