using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TicTacToe : MonoBehaviour {
	public static List<GameObject> grid;
	public GameObject boxPrefab;
	public static int turn = 1;

	// Use this for initialization
	void Start () {
		grid = new List<GameObject> ();
		for (int i=-1; i<2; i++){
			for (int j=-1; j<2; j++){
				GameObject tBoxGO = Instantiate (boxPrefab) as GameObject;
				Vector3 pos = Vector3.zero;
				pos.y = i;
				pos.x = j;
				tBoxGO.transform.position = pos;
				grid.Add (tBoxGO);
			}
		}
	}
	// Update is called once per frame
	public static void CheckWin () {
		Color[] results = new Color[3];
		for (int i = 0; i<7; i+=3){
			for (int j = 0; j<3; j++){ 
				results[j] = grid [i+j].transform.renderer.material.color;
			}
			checkResults(results);
		}
		for (int i = 0; i<3; i++){
			for (int j = 0; j<7; j+=3){ 
				results[j/3] = grid [i+j].transform.renderer.material.color;
			}
			checkResults(results);
		}
		for (int i = 0; i<3; i++){
			results[i] = grid[i*4].transform.renderer.material.color; 
			checkResults(results);
		}
		for (int i = 0; i<3; i++){
			results[i] = grid[(i*2)+2].transform.renderer.material.color; 
			checkResults(results);
		}
		
	}
	public static Color checkResults(Color[] results){
		if (results[0] == Color.red && results[1] == Color.red && results[2] == Color.red){
			Debug.Log ("Red Wins!"); 
			return Color.red;
		}
		if (results [0] == Color.blue && results [1] == Color.blue && results [2] == Color.blue) {
			Debug.Log ("Blue Wins!"); 
			return Color.blue;
		} else {
			return Color.white;
		}
	}
}
