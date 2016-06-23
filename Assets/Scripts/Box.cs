using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	Color player;
	bool active = true;
	// Use this for initialization
	void OnMouseDown(){
		if(Input.GetMouseButtonDown (0) && active) {
			if (TicTacToe.turn == 1) {
				//player = new Color (255, 0, 0, 1);
				this.gameObject.renderer.material.color = Color.red;
			} else {
				this.gameObject.renderer.material.color = Color.blue;
				//player = new Color (0, 0, 255, 1);
			}
			TicTacToe.turn *= -1;
			active = false;
			TicTacToe.CheckWin();
		}
	}
}
