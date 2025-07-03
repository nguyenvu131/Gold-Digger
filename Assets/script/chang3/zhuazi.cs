using UnityEngine;
using System.Collections;

public class zhuazi : MonoBehaviour {
	public UISprite a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position = a.transform.position;
	
	}
}
