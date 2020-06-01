using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour
{
    public int Health = 100;
    public void OnFire()
    {
        Health -= 15;
        DeathControl();
    }
    public void DeathControl()
    {
        if(Health <= 0)
        {
            Debug.Log("Destroyed Tank");
            Destroy(this.gameObject);
            
        }
    }
}
