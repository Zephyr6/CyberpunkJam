using UnityEngine;
using System.Collections;

public class DialoguerTestSceneMain : MonoBehaviour {
	
	public UnityDefaultGuiManager unityDialogue;
	public OldSchoolRPGDialogueGUI oldRpgDialogue;
	public NextGenRpgDialogueGui nextGenRpgDialogue;
	
	private readonly string GLOBAL_VARIABLE_SAVE_KEY = "serialized_global_variable_state";
	
	//private string returnedString = string.Empty;
	
	void Start () {
		
		// Initialize the Dialoguer
		Dialoguer.Initialize();
		
		// If the Global Variables state already exists, LOAD it into Dialoguer
		if(PlayerPrefs.HasKey(GLOBAL_VARIABLE_SAVE_KEY)){
			Dialoguer.SetGlobalVariablesState(PlayerPrefs.GetString(GLOBAL_VARIABLE_SAVE_KEY));
			//returnedString = PlayerPrefs.GetString(GLOBAL_VARIABLE_SAVE_KEY);
		}
	}
	
	void Update () {
		//returnedString = Dialoguer.GetGlobalVariablesState();
	}
	
	void OnGUI(){
		GUI.depth = -10;

		
	}
}
