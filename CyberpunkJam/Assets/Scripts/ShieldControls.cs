using UnityEngine;
using System.Collections;

public class ShieldControls : MonoBehaviour {

    public bool canMove;

	void Update () {
        if (canMove)
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
