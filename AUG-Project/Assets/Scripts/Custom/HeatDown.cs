using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class HeatDown: MonoBehaviour, IVirtualButtonEventHandler
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

        GameObject virtualButtonHeatUp = GameObject.Find("HeatDown");
        virtualButtonHeatUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentHeat = InitValues.currentHeat;

        // check if free trempreature step is available
        GameObject heatIcon = GameObject.Find("HeatIcon");
        if (currentHeat >= InitValues.freeTempreatureStep)
        {
            heatIcon.GetComponent<Renderer>().enabled = true;

            int heatMultiplier = currentHeat / InitValues.freeTempreatureStep;
            GameObject heatIconMultiplier = GameObject.Find("HeatIconMultiplier");

            if (heatMultiplier > 1)
            {
                // set multiplier value
                TextMesh heatIconMultiplierText = heatIconMultiplier.GetComponent<TextMesh>();
                heatIconMultiplierText.text = heatMultiplier + "x";

                heatIconMultiplier.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                heatIconMultiplier.GetComponent<Renderer>().enabled = false;
            }
        }
        else
        {
            heatIcon.GetComponent<Renderer>().enabled = false;
        }

        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentHeat = InitValues.currentHeat;

        if (currentHeat >= 1 && frameCounter > 100)
        {
            // calc new value
            TextMesh HeatText = GameObject.Find("HeatText").GetComponent<TextMesh>();
            int newHeat = currentHeat - stepSize;

            // change label
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