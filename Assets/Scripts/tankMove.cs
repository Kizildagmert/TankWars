using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankMove : MonoBehaviour
{
    public Joystick joystick;
    float horizontal, vertical;
    public float TankSpeed;
    public float BulletSpeed;
    public GameObject BulletPrefab;

    private float Speed = 3.0f;
    private float rotationSpeed = 180.0f;
    private float lowerBorder = -4.0f;
    private float upperBorder = 4.0f;
    private float leftBorder = -12.0f;
    private float rightBorder = 12.0f;
    


    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -1 * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
           
            transform.position += -1 * transform.up * Time.deltaTime * Speed;
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.position += transform.up * Time.deltaTime * Speed;
           
        }

    }
    

   
    public void GunFire() 
    {
        GameObject gBullet = Instantiate(BulletPrefab);
        gBullet.GetComponent<bulletScript>().SendObject = this.gameObject;
        gBullet.transform.position = this.transform.position;
        gBullet.GetComponent<Rigidbody2D>().AddForce(this.transform.up * BulletSpeed);
    }
}
