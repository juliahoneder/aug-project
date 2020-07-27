using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InitValues : MonoBehaviour
{
    public static int initialMegaCredit = 20;
    public static int initialSteel = 0;
    public static int initialTitanium = 0;
    public static int initialPlant = 0;
    public static int initialEnergy = 0;
    public static int initialHeat = 0;

    public static int currentMegaCredit = initialMegaCredit;
    public static int currentSteel = initialSteel;
    public static int currentTitanium = initialTitanium;
    public static int currentPlant = initialPlant;
    public static int currentEnergy = initialEnergy;
    public static int currentHeat = initialHeat;

    public static int freeGreeneryPlacement = 2;
    public static int freeTempreatureStep = 8;

    // Start is called before the first frame update
    void Start()
    {
        this.setValues();
        this.hideAllIcons();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValues()
    {
        // MegaCredit
        TextMesh megaCreditText = GameObject.Find("MegaCreditText").GetComponent<TextMesh>();
        megaCreditText.text = initialMegaCredit.ToString();

        // Steel
        TextMesh steelText = GameObject.Find("SteelText").GetComponent<TextMesh>();
        steelText.text = initialSteel.ToString();

        // Titanium
        TextMesh titaniumText = GameObject.Find("TitaniumText").GetComponent<TextMesh>();
        titaniumText.text = initialTitanium.ToString();

        // Plant
        TextMesh plantText = GameObject.Find("PlantText").GetComponent<TextMesh>();
        plantText.text = initialPlant.ToString();

        // Energy
        TextMesh energyText = GameObject.Find("EnergyText").GetComponent<TextMesh>();
        energyText.text = initialEnergy.ToString();

        // Heat
        TextMesh heatText = GameObject.Find("HeatText").GetComponent<TextMesh>();
        heatText.text = initialHeat.ToString();
    }

    public void hideAllIcons()
    {
        // Plant
        GameObject plantIconMultiplier = GameObject.Find("PlantIconMultiplier");
        plantIconMultiplier.GetComponent<Renderer>().enabled = false;

        GameObject plantIcon = GameObject.Find("PlantIcon");
        plantIcon.GetComponent<Renderer>().enabled = false;

        // Heat
        GameObject heatIconMultiplier = GameObject.Find("HeatIconMultiplier");
        heatIconMultiplier.GetComponent<Renderer>().enabled = false;

        GameObject heatIcon = GameObject.Find("HeatIcon");
        heatIcon.GetComponent<Renderer>().enabled = false;
    }
}
