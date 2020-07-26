using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class MegaCreditUp : MonoBehaviour, IVirtualButtonEventHandler
{
    public int initialCredit = 20;
    public int productionCredit = 1;
    private int currentCredit = 20;
    private int stepSize = 1;
    private int frameCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
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
        UnityEngine.Debug.Log("Button pressed");
        UnityEngine.Debug.Log(currentCredit);

        if (frameCounter > 5)
        {
            TextMesh creditText = GameObject.Find("MegaCreditText").GetComponent<TextMesh>();
            int newCredit = currentCredit + stepSize;

            currentCredit = newCredit;
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