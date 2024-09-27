using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrage : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField] GameObject gameObject;
    [SerializeField] int cont = 10;

    public int barragehp = 1;

    private Rigidbody2D rigidbody2D;
    static int number = 0;
    private float timeElapsed = 0;  

    private void Update()
    {

        RandomBarrage();

        
    }

    public void RandomBarrage()
    {
        if (playerTransform != null && number <= cont)
        {

            Vector2 PlayerPos = transform.position;

            System.Random rand = new System.Random();

            float xPos = rand.Next((int)PlayerPos.x - 10, (int)PlayerPos.x + 10);
            float yPos = rand.Next((int)PlayerPos.y -10, (int)PlayerPos.y + 10);

            Vector2 randomPos = new Vector2(xPos, yPos);

            Instantiate(gameObject, randomPos, Quaternion.identity);
            number++;   
        }



    }


  

}
