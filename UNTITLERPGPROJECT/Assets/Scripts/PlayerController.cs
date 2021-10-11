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
public class PlayerController : MonoBehaviour {
    private PlayerMouse  mouse_;
    private PlayerCamera camera_;

    void Start() {
        mouse_  = gameObject.AddComponent<PlayerMouse>() as PlayerMouse;
        camera_ = gameObject.AddComponent<PlayerCamera>() as PlayerCamera;
    }
}