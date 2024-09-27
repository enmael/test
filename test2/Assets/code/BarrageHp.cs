using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrageHp : MonoBehaviour
{
    public int barragehp = 2;
    private float timeElapsed = 0;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("player"))
        {
            barragehp--;
        }
    }

    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (barragehp == 0 && timeElapsed >3.0f )
        {
            Destroy(gameObject);
            timeElapsed = 0f;
        }
    }
}
