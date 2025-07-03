using UnityEngine;
using System.Collections;

public class help : MonoBehaviour {
	int page = 1;
	public Texture[] tex;
	public GameObject buttonqian;
	public GameObject buttonhou;
	// Use this for initialization
	void Start () 
	{
		buttonhou.SetActive (false);
	}

	public void OnClickHelpTowad()
	{
		if (page == 1) 
		{
			this.GetComponent<UITexture>().mainTexture = tex[page];
			page++;
			buttonhou.SetActive(true);
		}
		else if (page == 2) 
		{
			this.GetComponent<UITexture>().mainTexture = tex[page];
			page++;
			buttonqian.SetActive(false);
		}
	}

	public void OnClickHelpBack()
	{
		if (page == 2) 
		{
			this.GetComponent<UITexture>().mainTexture = tex[page-2];
			page--;
			buttonhou.SetActive(false);
		}
		else if (page == 3) 
		{
			this.GetComponent<UITexture>().mainTexture = tex[page-2];
			page--;
			buttonqian.SetActive(true);
		}
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}
