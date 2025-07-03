using UnityEngine;
using System.Collections;

public class kuanggong : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		shengzi_sc b = FindObjectOfType<shengzi_sc> ();
		
		
		if (b.statu  == 3 || b.statu == 2) {
			UISpriteAnimation i = GetComponent<UISpriteAnimation> ();
			i.enabled = true;
		}
		else if (b.statu == 0) 
		{
			UISpriteAnimation i = GetComponent<UISpriteAnimation> ();
			i.enabled = false;
			
		}
	
	}
}
