using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;


/*
 * <summary>
 * </summary>
 * <param name=""></param>
 * <returns>void</returns>
 */
public class Player : MonoBehaviour {
    private Health           _playerHealth;
    private PlayerController _playerControls;
    private Timer            _playerTimer;


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    private void Start() {
        _playerHealth = gameObject.AddComponent<Health>() as Health;
        _playerControls = gameObject.AddComponent<PlayerController>() as PlayerController;
        _playerTimer = gameObject.AddComponent<Timer>() as Timer;

        // Function to call out.

    }

    protected void Update() {
        if (!_playerHealth.get_death()) {

        }
    }
}