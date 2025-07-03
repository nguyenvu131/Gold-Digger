using UnityEngine;
using System.Collections;

public class game : MonoBehaviour {


	public UILabel MyGold;

	public GameObject xingyuncao;
	public GameObject yaoshui;
	public GameObject zhayao;
	public GameObject book;
	
	int a;

	public void OnClickXingyuncao()
	{
		xingyuncao.SetActive (true);
		yaoshui.SetActive (false );
		zhayao.SetActive (false );
		book.SetActive (false );
		a = 100;
	}

	public void OnClickYaoshui()
	{
		xingyuncao.SetActive (false );
		yaoshui.SetActive (true );
		zhayao.SetActive (false );
		book.SetActive (false );
		a = 200;
	}

	public void OnClickZhayao()
	{
		xingyuncao.SetActive (false );
		yaoshui.SetActive (false );
		zhayao.SetActive (true );
		book.SetActive (false );
		a = 300;	
	}


	public void OnClickBook()
	{
		xingyuncao.SetActive (false );
		yaoshui.SetActive (false );
		zhayao.SetActive (false );
		book.SetActive (true  );
		a = 400;
	}

	
	// Use this for initialization
	void Start ()
	{ 
		xingyuncao.SetActive (false);


		if (data.getyaoshui () == 0) 
		{
			yaoshui.SetActive (false);
		} 
		else 
		{
			yaoshui.SetActive (true );
		}


		if(data.getzhadan() == 0)
		{
			zhayao.SetActive (false );
		}
		else
		{
			zhayao.SetActive(true);
		}


		book.SetActive (false );

		//MyGold.text = ""+data.getgood();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	
	public void xiayiguan()
	{
		Application.LoadLevel(3);
	}
	
	public void OnMyGoldButtonClick()
	{
		
		data.usegold (a);
		MyGold.text = "" + data.getgood ();

		Debug.Log (data.getzhadan ());
		Debug.Log (data.getyaoshui());
				    
	}
	
}