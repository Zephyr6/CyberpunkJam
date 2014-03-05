using UnityEngine;
using System.Collections;

public class BatteryManager : MonoBehaviour {

    public int MaxBattery = 100;
    public bool isUsingShield = false;
    public GameObject text;
    public int speed = 30;

    private int CurrentBattery;

    void Start()
    {
        CurrentBattery = MaxBattery * speed;
    }

	void Update () 
    {
        if (text != null)
            text.GetComponent<TextMesh>().text = (CurrentBattery / speed) + "/" + MaxBattery;


	}

    void FixedUpdate()
    {
        bool canMove = true;
        ShieldControls shield = GetComponentInChildren<ShieldControls>();
        if (shield != null)
            canMove = shield.canMove;
        
        if (isUsingShield && canMove)
        {
            CurrentBattery--;

            if (CurrentBattery <= 0)
                CurrentBattery = 0;
        }

        if (shield != null)
            shield.hasEnergy = CurrentBattery > 0;
    }
}
