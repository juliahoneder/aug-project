using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class SteelUp : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialSteel = InitValues.initialSteel;
    private int currentSteel;
    public int productionSteel = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentSteel = InitValues.currentSteel;

        GameObject virtualButtonSteelUp = GameObject.Find("SteelUp");
        virtualButtonSteelUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentSteel = InitValues.currentSteel;

        if (frameCounter > 100)
        {
            // calc new value
            TextMesh steelText = GameObject.Find("SteelText").GetComponent<TextMesh>();
            int newSteel = currentSteel + stepSize;

            // change label
            InitValues.currentSteel = newSteel;
            steelText.text = newSteel.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        frameCounter = 0;
    }
}