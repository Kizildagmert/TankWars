using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankMove : MonoBehaviour
{

    private float lowerBorder = -4.0f;
    private float upperBorder = 4.0f;
    private float leftBorder = -12.0f;
    private float rightBorder = 12.0f;

     public float moveSpeed;
     private Rigidbody2D myRigidbody;
     public float BulletSpeed;
     public bool isWalking;
     public float walkTime;
     private float walkCounter;
     public float waitTime;
     public float waitCounter;
     private Vector2 walkRange;
     private int WalkDirection;
     public GameObject BulletPrefab;
     void Start()
     {
         myRigidbody = GetComponent<Rigidbody2D>();

         waitCounter = waitTime;
         walkCounter = walkTime;

         ChooseDirection();


     }
     void Update()
     {
         if(isWalking)
         {
             walkCounter -= Time.deltaTime;



             switch (WalkDirection)
             {
                 case 0:
                     myRigidbody.velocity = new Vector2(0, moveSpeed);
                     break;

                 case 1:
                     myRigidbody.velocity = new Vector2(moveSpeed,0);
                     break;

                 case 2:
                     myRigidbody.velocity = new Vector2(0, -moveSpeed);
                     break;

                 case 3:
                     myRigidbody.velocity = new Vector2(-moveSpeed,0);
                     break;

             }
             if (walkCounter < 0)
             {
                 isWalking = false;
                 waitCounter = waitTime;
             }

         }
         else
         {
             waitCounter -= Time.deltaTime;
             myRigidbody.velocity = Vector2.zero;
             if(waitCounter < 0)
             {
                 ChooseDirection();
             }
         }
     }

     public void ChooseDirection()
     {
         WalkDirection = Random.Range(0, 4);
         walkRange = new Vector2(Random.Range(-12f, 12f), Random.Range(-4f, 4f));
        

         isWalking = true;
         walkCounter = walkTime;
     }

    

}




















