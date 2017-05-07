using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontroller : MonoBehaviour {

    public GameObject player;
    public GameObject Img;
    public Light imgLight;

    // Use this for initialization
    void Awake() {
  }
	
	// Update is called once per frame
	void Update () {
        
        if ( Input.GetMouseButton(1) )
        {
            var pos = Input.mousePosition;
            pos.z = 5;
            transform.position = Camera.main.ScreenToWorldPoint(pos);
            transform.position = new Vector3(transform.position.x, transform.position.y, -0.1f);
        } else
        {
            transform.position = player.transform.position;
            transform.position = new Vector3(transform.position.x, transform.position.y, -0.1f);
        }
        float distance = Vector3.Distance(transform.position, Img.transform.position);
        if ( distance <= 1 )
        {   if (imgLight.range < 15)
            {
                imgLight.range += 0.1f;
            }
        }
       
    }
}
