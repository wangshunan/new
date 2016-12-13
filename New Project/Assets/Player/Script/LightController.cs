using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	private GameObject Sphere;
	Color color;

	// Use this for initialization
	void Start () {
		Sphere = GameObject.Find("Sphere");
	}
	
	// Update is called once per frame
	void Update () {

		color = Sphere.GetComponent<MeshRenderer> ().material.GetColor("_EmissionColor");
		gameObject.GetComponent<Light> ().color = color;
	}
}
