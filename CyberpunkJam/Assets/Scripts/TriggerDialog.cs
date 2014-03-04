using UnityEngine;
using System.Collections;

public class TriggerDialog : MonoBehaviour {

    public DialoguerDialogues dialog;

    private OldSchoolRPGDialogueGUI dialogGUI;
    private bool isActive = true;

	// Use this for initialization
	void Start () {
        dialogGUI = GameObject.FindGameObjectWithTag("Dialog").GetComponent<OldSchoolRPGDialogueGUI>();
	}

    void OnTriggerEnter2D(Collider2D c)
    {
        if (isActive)
        {
            dialogGUI.StartDialog(dialog);
            isActive = false;
        }
    }
}
