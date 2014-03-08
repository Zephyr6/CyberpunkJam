using UnityEngine;
using System.Collections;

public class ContinueButton : MonoBehaviour 
{
	private string SavedLevel;
	private bool canContinue;

	void Awake()
	{
		canContinue = true;
		SavedLevel = PlayerPrefs.GetString ("Level");
		if (SavedLevel == "" || SavedLevel == null)
		{
			canContinue = false;
		}
	}
	
	void OnMouseOver()
	{
		if (canContinue)
		{
			//Add effects to gui to highlight or play a noise or whatever
		}
	}
	
	void OnMouseExit()
	{
		if(canContinue)
		{
			//Add effect cancelations if needed.
		}
	}
	
	void OnMouseUp()
	{
		if(canContinue)
		{
			//Add other things like play sound etc etc.
			LoadLevel ();
		}
	}

	void LoadLevel()
	{
		Application.LoadLevel(SavedLevel);
	}
}
