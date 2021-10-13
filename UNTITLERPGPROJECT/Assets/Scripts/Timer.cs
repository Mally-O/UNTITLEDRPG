using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



/*
 * <summary>
 * </summary>
 * <param name=""></param>
 * <returns>void</returns>
 */
public class Timer : MonoBehaviour {
    private float        _start_time;
    private float        _end_time;
    private List<Player> _playerIds;


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    protected void Start() {
        _start_time = Time.time;
    }


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    protected void Update() {
        // var players[] = FindGameObjectWithTag("player");
        // object players = FindGameObjectWithTag('player');
    }


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    protected void Stop() {
        _end_time = Time.time;
    }
}