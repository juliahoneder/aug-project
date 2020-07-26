using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class MegaCreditDown : MonoBehaviour, IVirtualButtonEventHandler
{
    public int initialCredit = 20;
    public int productionCredit = 1;
    private int currentCredit = 20;
    private int stepSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject virtualButtonMegaCreditDown = GameObject.Find("MegaCreditDown");
        virtualButtonMegaCreditDown.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Button pressed");

        
        if (currentCredit > 1)
        {
            TextMesh creditText = GameObject.Find("CreditText").GetComponent<TextMesh>();
            int newCredit = currentCredit - stepSize;

            currentCredit = newCredit;
            creditText.text = newCredit.ToString();
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Button released");
    }
}