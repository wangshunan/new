using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    private Vector3 mousePosition;
    private Vector3 screenToWorldPointPosition;

    float speed = 0.05f;

	// Use this for initialization
	void Start () {
        screenToWorldPointPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 5;
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            screenToWorldPointPosition.y = 0;
            screenToWorldPointPosition.z = 0;
        }

        gameObject.transform.position = Vector3.MoveTowards(transform.position, screenToWorldPointPosition, speed);
        
    }
}
