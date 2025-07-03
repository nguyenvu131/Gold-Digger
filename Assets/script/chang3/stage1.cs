using UnityEngine;
using System.Collections;
//using UnityEditorInternal;
public class stage1 : MonoBehaviour
{
	public UIPanel gameOverpanel;
	public UIPanel nextStagepanel;
	public UILabel scoreLabel;
	//public int score = 0;
	public UILabel time_control;
	public int fen;
	public int miao;
	public bool control;
	public int target;
	// Use this for initialization
	void Awake()
	{
		
	}
	void Start () 
	{
		gameOverpanel.gameObject.SetActive (false);
		nextStagepanel.gameObject.SetActive (false);
		InvokeRepeating ("control_time", 0,1);
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreLabel.text = "" + data.getgood ();
		if(miao==0&&fen==0)
		{
			control=true;
			stage1 k = FindObjectOfType<stage1>();
			k.GameOver();
		}
		
		
	}
	public void OnBackButtonClick()
	{	
		Application.LoadLevel ("kaishijiemian");
		data.delet_all (); 
	}
	
	public void on_restratbuttonclick()
	{
		Application.LoadLevel("kaishijiemian");
		data.delet_all ();
	}
	public void GameOver()
	{
		
		if (data.getgood() >= target)
		{
			nextStagepanel.gameObject.SetActive (true);	
		}
		else 
		{
			gameOverpanel.gameObject.SetActive (true);
		}
		
	}
	public void OnRestartButtonClick()
	{
		Application.LoadLevel ("game");
		data.delet_all ();
	}
	
	public void OnNextStageButtonclick()
	{
		Application.LoadLevel ("shangdian");
	}

	
	public void control_time()
	{   
		if(control)
		{
			return;
		}
		if(miao==0)
		{
			miao=59;
			fen--;
		}
		miao--;
		time_control.text = fen + ":" + miao;
	}
	
}