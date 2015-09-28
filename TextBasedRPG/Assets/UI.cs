using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {
	public GUISkin usrInterface;
	// Use this for initialization
	void Start ()
	{

	}
	void OnGui()
	{
		GUI.skin = usrInterface;
		GUI.Button (new Rect (10, 10, 60, 10), "Attack");
		GUI.Button (new Rect (10, 20, 60, 10), "Defend");
		GUI.Button (new Rect (10, 30, 60, 10), "Item");
		GUI.Button (new Rect (10, 40, 60, 10), "Run");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
