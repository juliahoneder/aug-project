using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class EnergyDown : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialEnergy = InitValues.initialEnergy;
    private int currentEnergy;
    public int productionEnergy = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = InitValues.currentEnergy;

        GameObject virtualButtonEnergyUp = GameObject.Find("EnergyDown");
        virtualButtonEnergyUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentEnergy = InitValues.currentEnergy;

        if (currentEnergy >= 1 && frameCounter > 100)
        {
            // calc new value
            TextMesh energyText = GameObject.Find("EnergyText").GetComponent<TextMesh>();
            int newEnergy = currentEnergy - stepSize;

            // change label
            InitValues.currentEnergy = newEnergy;
            energyText.text = newEnergy.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        frameCounter = 0;
    }
}