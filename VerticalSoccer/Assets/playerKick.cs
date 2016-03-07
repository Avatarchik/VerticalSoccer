using UnityEngine;
using System.Collections;

public class playerKick : MonoBehaviour {

	public bool kicked;

	private float moveHoriz;
	private float moveVert;
	private float moveHorizR;
	private float moveVertR;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		moveHoriz = Input.GetAxis("Horizontal");
		moveVert = Input.GetAxis("Vertical");
		moveHorizR = Input.GetAxis("HorizontalRIGHT");
		moveVertR = Input.GetAxis("VerticalRIGHT");

		if (moveVertR > 0 || moveVertR < 0 || moveHorizR > 0 || moveHorizR < 0) {
			Invoke ("kT", 0.09f);
		} else if (moveVertR == 0 && moveHorizR == 0) {
			kicked = false;
		}
	
	}

	void kT(){
		kicked = true;
	}

}
