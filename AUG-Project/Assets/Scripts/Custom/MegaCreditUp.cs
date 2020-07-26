using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class MegaCreditUp : MonoBehaviour, IVirtualButtonEventHandler
{
    private int initialMegaCredit = InitValues.initialMegaCredit;
    private int currentMegaCredit;
    public int productionCredit = 1;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentMegaCredit = InitValues.currentMegaCredit;

        GameObject virtualButtonMegaCreditUp = GameObject.Find("MegaCreditUp");
        virtualButtonMegaCreditUp.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        currentMegaCredit = InitValues.currentMegaCredit;

        UnityEngine.Debug.Log("Button pressed");
        UnityEngine.Debug.Log("UP: " + InitValues.currentMegaCredit);
       
        if (frameCounter > 100)
        {
            TextMesh creditText = GameObject.Find("MegaCreditText").GetComponent<TextMesh>();
            int newCredit = currentMegaCredit + stepSize;

            InitValues.currentMegaCredit = newCredit;
            creditText.text = newCredit.ToString();

            frameCounter = 0;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Button released");

        frameCounter = 0;
    }
}