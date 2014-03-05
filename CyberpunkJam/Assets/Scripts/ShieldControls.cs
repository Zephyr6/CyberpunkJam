using UnityEngine;
using System.Collections;

public class ShieldControls : MonoBehaviour {

    public bool canMove;
    public bool hasEnergy = true;

	void Update () {
        if (canMove && hasEnergy)
        {
            renderer.enabled = Input.GetMouseButton(0);
            collider2D.enabled = Input.GetMouseButton(0);
        }
        else
        {
            renderer.enabled = false;
            collider2D.enabled = false;
        }
	}
}
