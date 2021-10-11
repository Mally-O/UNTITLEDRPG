using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 *
 */
public class Health : MonoBehaviour {
    // Entity health property.
    [SerializeField] private int health_ = 100;


    /*
     * <summary>
     *  Method to maintain watch over the entity's living state
     *  in relation to the object's health status.
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    private void Update() {
        if (health_ <= 0) {
            _Death();
        }
    }


    /*
     * <summary>
     *  Method to initiate death sequence in response to
     *  entity's health falling to or below zero.
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    private void _Death() {
        Destroy(gameObject);
    }


    /*
     * <summary>
     *  Method for getting entity's health.
     * </summary>
     * <param name=""></param>
     * <returns>returns int value representation of health.</returns>
     */
    public int _GetHealth() {
        return health_;
    }


    /*
     * <summary>
     *  Method to update the health of the entity.
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    public void _SetHealth(int adjValue) {
        health_ += adjValue;
    }
}