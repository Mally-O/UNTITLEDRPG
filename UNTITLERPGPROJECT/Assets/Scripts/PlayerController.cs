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
    private PlayerMouse  _mouse;
    private PlayerCamera _camera;

    void Start() {
        _mouse  = gameObject.AddComponent<PlayerMouse>() as PlayerMouse;
        _camera = gameObject.AddComponent<PlayerCamera>() as PlayerCamera;
    }
}