using UnityEngine;
using System.Collections;

public class shengzi_sc : MonoBehaviour {
	public GameObject[] golds;
	public int current;
	public UISprite efg;
	public GameObject you;
	//public UILabel scorelabel;
	float Speed;
	public float zhongliang;
	bool use_zhadan=false;
	// Use this for initialization
	public  int statu = 0;   //0:旋转 1:伸长 2:缩短 3:抓到

	public bool ifzha=false;
	public UILabel label;            //炸弹个数。
	public UILabel label2;           //药水的个数。
	public int geshu ;
	public int geshu2;
	public bool dianji = true;
	public bool yaoshui=false;
	public AudioSource baomusic ;//爆炸音效。
	void Start () 
	{
		//statu = 0;
		label.text=""+ data.getzhadan ();
		label2.text =""+ data.getyaoshui ();
		geshu = data.getzhadan ();
		geshu2 = data.getyaoshui ();
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		stage1 a = FindObjectOfType<stage1>();
		if (a.control)
		{
			return;
		}
		if (Input.GetKeyUp (KeyCode.DownArrow))
		{
			if(statu == 0)
			{
				statu = 1;
			}
		}
		
		if (statu == 0) 
		{
			xuanzhuan ();
		} 
		else if (statu == 1) 
		{
			
			shengzisc ();
		}
		else if (statu == 2)
		{
			shouhui ();
		} 
		else if (statu == 3)
		{

			statu = 0;
			Speed = 300f;

		}
		else if (statu == 4) 
		{
			statu = 2;
			gold g = FindObjectOfType <gold> ();
			Speed = zhongliang;
		}
			
	}
	
	public void shengzisc()
	{

		efg.transform.localScale += new Vector3 (0, 300*Time.deltaTime, 0);
		if (efg.transform.localScale.y > 900) 
		{
			statu = 2;
			Speed = 400f;
			
		}
	}
	
	public void shouhui()
	{  
		if(yaoshui)
		{
			Speed=450f;
			
		}
		efg.transform.localScale -= new Vector3 (0, Speed*Time.deltaTime, 0);
		if (efg.transform.localScale.y <= 10f)
		{
			statu = 0;
			statu=3;
			use_zhadan = false;
		}
	}
	int n = -1;
	public void xuanzhuan()
	{
		
		if (n < 0) 
		{
			this.transform.Rotate (0, 0, 40f * Time.deltaTime, Space.World);
			if (this.transform.rotation.z > 0.5f)
			{
				n = 1;
			}
		}
		if (n> 0)
		{
			this.transform.Rotate(0,0,-40f*Time.deltaTime,Space.World);
			if (this.transform.rotation.z < -0.5f)
			{
				n = -1;
			}
		}
	}
	void backspeed()
	{
		efg.transform.localScale += new Vector3 (0, 2f * Time.deltaTime * Speed, 0);
		
	}
	public void OnSpeediconButtonClick()
	{
		if(yaoshui)
		{
			return;
		}
		if (geshu2 > 0) 
		{
			yaoshui = true;
			Invoke("Timeyaoshui", 5f);
			geshu2--;
			label2.text=""+geshu2;
		}
	}
	public void Timeyaoshui()
	{
		yaoshui = false;
	}
	public void on_zhadan_button_click()
	{
		if (ifzha)
		{	
			if (geshu > 0)
			{    
				baomusic.Play ();
				use_zhadan = true;
				Destroy(you);
				ifzha = false;
				dianji = true;
				geshu--;
				label.text = "" + geshu;
				Speed=400f;
			} 
			else 
			{
				return;
			}
			
		}
	}

}