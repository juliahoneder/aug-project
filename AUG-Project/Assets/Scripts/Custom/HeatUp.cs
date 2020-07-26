using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class HeatUp : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialHeat = InitValues.initialHeat;
    private int currentHeat;
    public int productionHeat = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentHeat = InitValues.currentHeat;

        GameObject virtualButtonHeatUp = GameObject.Find("HeatUp");
        virtualButtonHeatUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentHeat = InitValues.currentHeat;

        if (frameCounter > 100)
        {
            TextMesh HeatText = GameObject.Find("HeatText").GetComponent<TextMesh>();
            int newHeat = currentHeat + stepSize;

            InitValues.currentHeat = newHeat;
            HeatText.text = newHeat.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        frameCounter = 0;
    }
}