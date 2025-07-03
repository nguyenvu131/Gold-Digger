using UnityEngine;
using System.Collections;

public class data
{
	public static void cun_gold(int a)
	{
		PlayerPrefs.SetInt ("GOLDCC", a);           //玩家偏好设定。
	}
	
	public static int getgood()
	{
		return PlayerPrefs.GetInt ("GOLDCC",0);
	}
	
	public static void addgold(int h)
	{
		int y = getgood ();
		cun_gold (h + y);
	}

	public static void usegold(int t)
	{
		int z=getgood ();
		if(z>t)
		{
			cun_gold (z - t);
			if(t==200)
			{
				addzhadan(1);
			}
			if(t==300)
			{
				addyaoshui(1);
			}
		}
	}
	
	
	public static void cun_zhadan(int a)
	{
		PlayerPrefs.SetInt ("ZHADANCC", a);
	}
	
	public static int getzhadan()
	{
		return PlayerPrefs.GetInt ("ZHADANCC", 0);
	}
	
	public static void addzhadan(int h)
	{
		int y = getzhadan ();
		cun_zhadan (h + y);
	}
	

	
	
	public static void cun_yaoshui(int a)
	{
		PlayerPrefs.SetInt ("yaoshuiCC", a);
	}
	
	public static int getyaoshui()
	{
		return PlayerPrefs.GetInt ("yaoshuiCC", 0);
	}
	
	public static void addyaoshui(int h)
	{
		int y = getyaoshui ();
		cun_yaoshui (h + y);
	}
	

	public static void delet_all()
	{
		PlayerPrefs.DeleteAll();
	}
}