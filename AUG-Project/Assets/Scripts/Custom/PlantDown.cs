using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class PlantDown : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialPlant = InitValues.initialPlant;
    private int currentPlant;
    public int productionPlant = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentPlant = InitValues.currentPlant;

        GameObject virtualButtonPlantDown = GameObject.Find("PlantDown");
        virtualButtonPlantDown.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentPlant = InitValues.currentPlant;

        // check if free plant placement is available
        GameObject plantIcon = GameObject.Find("PlantIcon");
        if (currentPlant >= InitValues.freeGreeneryPlacement)
        {
            plantIcon.GetComponent<Renderer>().enabled = true;

            int plantMultiplier = currentPlant / InitValues.freeGreeneryPlacement;
            GameObject plantIconMultiplier = GameObject.Find("PlantIconMultiplier");

            if (plantMultiplier > 1)
            {
                // set multiplier value
                TextMesh plantIconMultiplierText = plantIconMultiplier.GetComponent<TextMesh>();
                plantIconMultiplierText.text = plantMultiplier + "x";

                plantIconMultiplier.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                plantIconMultiplier.GetComponent<Renderer>().enabled = false;
            }
        }
        else
        {
            plantIcon.GetComponent<Renderer>().enabled = false;
        }

        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentPlant = InitValues.currentPlant;

        if (currentPlant >= 1 && frameCounter > 100)
        {
            // calc new value
            TextMesh plantText = GameObject.Find("PlantText").GetComponent<TextMesh>();
            int newPlant = currentPlant - stepSize;

            // change label
            InitValues.currentPlant = newPlant;
            plantText.text = newPlant.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        frameCounter = 0;
    }
}