using UnityEngine;
using System.Collections;

public class Database
{
	public static void Savejinbi(int count)
	{
		PlayerPrefs.SetInt("MyGold",count);  
	}
	
	public static void AddMyGold(int count)
	{
		int preCount = GetMyGoldCount ();
		Savejinbi (count + preCount);
	}
	public static int GetMyGoldCount()
	{
		return PlayerPrefs.GetInt ("MyGold");
	}
	public static void UsedMyGold(int count)
	{
		int s = GetMyGoldCount ();
		if (count <= s) {
			Savejinbi (s - count);
		}
		else
		{
			Debug.Log ("Not Enough Diamond"); 
		}
	}
}
