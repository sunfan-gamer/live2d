using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class accross : MonoBehaviour {
	public static bool ishave=false;
	public static int game_data;
	public static int money_data;
	public static int favor_data;
	public static int leftdays;
	public static int score;
	
	public static void ToString()
	{
		Debug.Log(ishave);
		Debug.Log(game_data);
		Debug.Log(money_data);
		Debug.Log(favor_data);
		Debug.Log(leftdays);
		Debug.Log(score);

	}
}
