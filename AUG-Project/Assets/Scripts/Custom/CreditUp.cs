using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Vuforia;

public class CreditUp : MonoBehaviour, IVirtualButtonEventHandler
{
    public int initialCredits = 20;
    public int productionSize = 1;
    public int defaultIncrement = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameObject virtualButtonObject = GameObject.Find("CreditUp");
        virtualButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Button pressed");
        TextMesh creditText = GameObject.Find("CreditText").GetComponent<TextMesh>(); ;
        creditText.text = initialCredits.ToString();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        UnityEngine.Debug.Log("Button released");
    }
}