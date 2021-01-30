﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    float originalWidth = 2960f;
    float originalHeight = 1440f;


    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Camera>().aspect = (originalWidth/originalHeight)*(Screen.width/Screen.height);
        player = GameObject.FindGameObjectWithTag ("Player");    
    }

    // Update is called once per frame
    void LateUpdate() {
        float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
    }
}
