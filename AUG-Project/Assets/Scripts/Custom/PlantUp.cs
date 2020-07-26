using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class PlantUp : MonoBehaviour, IVirtualButtonEventHandler
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

        GameObject virtualButtonPlantUp = GameObject.Find("PlantUp");
        virtualButtonPlantUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentPlant = InitValues.currentPlant;

        if (frameCounter > 100)
        {
            TextMesh plantText = GameObject.Find("PlantText").GetComponent<TextMesh>();
            int newPlant = currentPlant + stepSize;

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