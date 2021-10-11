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
    private float        start_;
    private float        end_;
    private List<Player> player_ids_;


    /*
     * <summary>
     * </summary>
     * <param name=""></param>
     * <returns>void</returns>
     */
    protected void Start() {
        start_ = Time.time;
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
        end_ = Time.time;
    }
}