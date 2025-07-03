using UnityEngine;
using System.Collections;

public class esc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnExitButtonClick()
	{
		Application.Quit (); 
		data.delet_all ();
	}
}
