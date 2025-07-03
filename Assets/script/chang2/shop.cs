using UnityEngine;
using System.Collections;

public class shop : MonoBehaviour {
	public UILabel label1;
	public UILabel label2;
	public UILabel label3;
	public UILabel label4;

	// Use this for initialization
	void Start () 
	{
		label1.enabled = false;
		label2.enabled = false;
		label3.enabled = false;
		label4.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnLuckyIconClick()
	{
		//		PageManager.manager.ShowPage (PageManager.label1,true);
		label1.enabled = true;
		label2.enabled = false;
		label3.enabled = false;
		label4.enabled = false;
	}
	public void OnC4BoomButtonClick()
	{
		//		PageManager.manager.ShowPage (PageManager.label2,true);
		label2.enabled = true;
		label3.enabled = false;
		label4.enabled = false;
		label1.enabled = false;
	}
	public void OnmagicbookButtonClick()
	{
		//		PageManager.manager.ShowPage (PageManager.label3,true);
		label3.enabled = true;
		label1.enabled = false;
		label2.enabled = false;
		label4.enabled = false;
	}
	public void OnstrongerBUttonClick()
	{
		//		PageManager.manager.ShowPage (PageManager.label4,true);
		label4.enabled = true;
		label1.enabled = false;
		label2.enabled = false;
		label3.enabled = false;
	}
	public void game()
	{
		Application.LoadLevel(3);
	}
}
