using UnityEngine;
using System.Collections;

public class goalScript : MonoBehaviour {

	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.CompareTag ("Ball")) {
			Destroy (other.gameObject, 0.2f);
			Instantiate (ball, new Vector2 (0, 0), transform.rotation);
		}
		
}
}