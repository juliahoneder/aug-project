using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InitValues : MonoBehaviour
{
    public int initialMegaCredit = 20;
    public int initialSteel = 0;
    public int initialTitanium = 0;
    public int initialPlant = 0;
    public int initialEnergy = 0;
    public int initialHeat = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.setValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setValues()
    {
        // MegaCredit
        TextMesh megaCreditText = GameObject.Find("MegaCreditText").GetComponent<TextMesh>(); ;
        megaCreditText.text = initialMegaCredit.ToString();

        // Steel
        TextMesh steelText = GameObject.Find("SteelText").GetComponent<TextMesh>(); ;
        steelText.text = initialSteel.ToString();

        // Titanium
        TextMesh titaniumText = GameObject.Find("TitaniumText").GetComponent<TextMesh>(); ;
        titaniumText.text = initialTitanium.ToString();

        // Plant
        TextMesh plantText = GameObject.Find("PlantText").GetComponent<TextMesh>(); ;
        plantText.text = initialPlant.ToString();

        // Energy
        TextMesh energyText = GameObject.Find("EnergyText").GetComponent<TextMesh>(); ;
        energyText.text = initialEnergy.ToString();

        // Heat
        TextMesh heatText = GameObject.Find("HeatText").GetComponent<TextMesh>(); ;
        heatText.text = initialHeat.ToString();
    }
}
