using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class TitaniumDown : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialTitanium = InitValues.initialTitanium;
    private int currentTitanium;
    public int productionTitanium = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentTitanium = InitValues.currentTitanium;

        GameObject virtualButtonTitaniumDown = GameObject.Find("TitaniumDown");
        virtualButtonTitaniumDown.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentTitanium = InitValues.currentTitanium;

        if (currentTitanium > 1 && frameCounter > 100)
        {
            TextMesh titaniumText = GameObject.Find("TitaniumText").GetComponent<TextMesh>();
            int newTitanium = currentTitanium - stepSize;

            InitValues.currentTitanium = newTitanium;
            titaniumText.text = newTitanium.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        frameCounter = 0;
    }
}