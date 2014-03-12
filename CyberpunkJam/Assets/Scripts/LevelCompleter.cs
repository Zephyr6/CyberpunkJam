using UnityEngine;
using System.Collections;

public class LevelCompleter : MonoBehaviour 
{
	
	void Awake () 
	{
		PlayerPrefs.SetString ("Level", "TestSceneClint");
		PlayerPrefs.Save ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			PlayerPrefs.SetString("Level", "TestScene"); 
			PlayerPrefs.Save();

			Application.LoadLevel("TestScene");
		}
	}
}
