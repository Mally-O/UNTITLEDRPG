using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health_ = 100;


    private void _Update_Status()
    {
        if (health_ <= 0)
        {
            _Death();
        }
    }


    private void _Death()
    {
        Destroy(gameObject);
    }


    public int _GetHealth() const
    {
        return health_;
    }


    public void _SetHealth(int adj_value)
    {
        health_ += adj_value;
    }
}
