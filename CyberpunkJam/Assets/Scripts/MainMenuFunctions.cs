using UnityEngine;
using System.Collections;

public class MainMenuFunctions : MonoBehaviour 
{

	//private AudioSource audio;
	private string selected;

	void Awake () 
	{
		//audio = GetComponent<AudioSource>();
	}

	void Update () 
	{
		if (Input.GetKey(KeyCode.Mouse0) && selected != "")
		{
			switch (selected)
			{
				case "NewGameButton":
					//Load the first of the game Application.LoadLevel
				break;

				case "ContinueButton":
					//Load the userPrefs to their current level.
				break;

				case "CreditsButton":
					//Load the Credits screen.
				break;

				case "ExitGameButton":
					Application.Quit();
				break;
			}
		}
	}
	
	void OnMouseEnter()
	{
		//audio.clip = ;  This is where we will set the sound for when the mouse moves over the button
		//audio.Play();
	}

	void OnMouseExit()
	{
		//if we want to highlight and unhighlight buttons this will be used.
		selected = "";
	}

}
