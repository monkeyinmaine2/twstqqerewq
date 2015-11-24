using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed = 0.0f;

	void start(){
	}
	void Update(){
		Rightkey();
		Leftkey ();
		Upkey ();
		Downkey ();
	}
	void Rightkey(){
		bool right = Input.GetKey (KeyCode.RightArrow);
			if (right){
				transform.position = transform.position + Vector3.right * speed;
		}
	}

	void Leftkey(){
		bool left = Input.GetKey (KeyCode.LeftArrow);
			if (left) {
				transform.position = transform.position + Vector3.left * speed;
		}
	}

	void Upkey(){
		bool up = Input.GetKey (KeyCode.UpArrow);
			if (up) {
				transform.position = transform.position + Vector3.up * speed;
		}
	}
	
	void Downkey(){
		bool down = Input.GetKey (KeyCode.DownArrow);
			if (down) {
				transform.position = transform.position + Vector3.down * speed;
		}
	}
}