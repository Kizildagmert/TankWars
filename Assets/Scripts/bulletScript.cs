using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
  public GameObject SendObject;
  

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name.Contains("enemytank"))
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);

        }

    }
        public void onTriggerEnter2D(Collider2D collison)

        {
        if(collison.tag == "tankplayer"){
            if(SendObject != collison.gameObject)
            {
                collison.gameObject.GetComponent<TankHealth>().OnFire();
                Destroy(this.gameObject);
                
            }
            
        }
        if(collison.tag == "barrier1")
        {
            Destroy(this.gameObject);
        }
        if(collison.tag == "barrier")
        {
            Destroy(this.gameObject);
        }
    }
 
}




