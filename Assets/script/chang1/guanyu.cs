using UnityEngine;
using System.Collections;

public class guanyu : MonoBehaviour
{
	public UIPanel aboutpanel;


	// Use this for initialization
	void Start ()
	{
		aboutpanel.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
	public void OnAboutButtonClick()
	{
		aboutpanel.enabled = true;
	}
	public void OnReturnButtonClick()
	{
		aboutpanel.enabled = false;
	}
}
