using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private GameObject player;
    private Rigidbody playerRig;

    private float speed;
    //private float jumpPower;


    void Awake() {
        player = GameObject.Find( "Player" );
        speed = 1.0f;
        //jumpPower = 50.0f;

    }
       
    void Start() {
        playerRig = player.GetComponent<Rigidbody>( );
    }

	void Update () {
        playerCro( );
	}

    void playerCro() {

        if ( Input.GetAxis( "Horizontal" ) != 0 ) {
            float axis = Input.GetAxis( "Horizontal" );
            playerRig.AddForce( axis * speed, 0, 0, ForceMode.Impulse );
        }


        // jump実装待つ
        /*if ( Input.GetButtonDown( "Jump" ) ) {
            playerRig.AddForce( 0, jumpPower, 0, ForceMode.Impulse );
        }*/
    }
}
