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
    private Health           player_Health_;
    private PlayerController player_Controls_;
    private Timer            player_Timer_;


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    private void Start() {
        player_Health_ = gameObject.AddComponent<Health>() as Health;
        player_Controls_ = gameObject.AddComponent<PlayerController>() as PlayerController;
        player_Timer_ = gameObject.AddComponent<Timer>() as Timer;
    }
}