using UnityEngine;
using System.Collections;

public class gold : MonoBehaviour {
	public int score;
	public float weight;
	public GameObject u;
	public int name;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter(Collider other)
	{
		shengzi_sc asd = FindObjectOfType<shengzi_sc> ();
		asd.you = this.gameObject;
		if(asd.statu == 1)
		{
			InvokeRepeating ("gold_move",0f,0.01f);

			asd.statu = 4;
			asd.ifzha = true;
			asd.zhongliang = weight;
			GameObject u = this.gameObject;
			this.fuzhiname ();
		}
	}
	
	public void gold_move()
	{
		zhuazi A = FindObjectOfType<zhuazi>();
		this.transform.position = A.transform.position;

		if (this.transform.position.y >= 0.4f)
		{
			GameObject.Destroy (this.gameObject);
			data.addgold(score);
		}
	}
	public void gold_destroy()
	{
		Destroy (u);
	}
	public void fuzhiname()
	{
		shengzi_sc lll = FindObjectOfType<shengzi_sc> ();
		lll.current = name;
	}
}
