﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
    public float sensitivity = 500f;
    public float rotationY;

	GameObject character;

	// Use this for initialization
	void Start_AAA () {
		character = this.transform.parent.gameObject;
	}
	
	void Update () {
        float mouseMoveX = Input.GetAxis("Mouse X");
        rotationY += change * Time.deltaTime;
        rotationX += changed * sensitivity * Time.deltaTime;
        rotationZ += 0;

        if (rotationX > 35f)
            rotationX = 35f;
        if (rotationX < -0f)
            rotationX = -0f;

       // transform.eulerAngles = new Vector3(-rotationX, rotationY, 0f);
		transform.localRotation = Quaternion.AngleAxis(-rotationX,  Vector3.right);
		character.transform.localRotation = Quaternion.AngleAxis(rotationY, character.transform.up);
    }
}
