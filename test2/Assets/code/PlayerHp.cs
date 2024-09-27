using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    //private int hp = 1;

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if(col.gameObject.CompareTag("barrage"))
    //    {
    //        hp--;
    //    }
    //}

    //private void Update()
    //{

    //    if(hp == 0) 
    //    {
    //        Destroy(gameObject);
    //        Debug.Log("Game over");
    //    }
    //}

    private int hp = 1; // 초기 체력

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("barrage")) 
        {
            TakeDamage(1); 
        }
    }

    private void TakeDamage(int damage)
    {
        hp -= damage;


        if (hp <= 0 )
        {
            Die(); 
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Debug.Log("Game over");
    }
}
