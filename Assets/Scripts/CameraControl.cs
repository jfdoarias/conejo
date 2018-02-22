using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    public Vector3 miEsfera;

    //public Transform target;



	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
         
        transform.LookAt(miEsfera);

		
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);


        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

       
	}
}
