using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPlayerOptions : MonoBehaviour
{

    public static int initialMegaCredit = 20;
    public static int initialSteel = 0;
    public static int initialTitanium = 0;
    public static int initialPlant = 0;
    public static int initialEnergy = 0;
    public static int initialHeat = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.hideAllBackgrounds();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hideAllBackgrounds()
    {
        // Sell Plants
        GameObject sellPlantsBackground = GameObject.Find("SellPlantsBackground");
        sellPlantsBackground.SetActive(false);

        // Power Plant
        GameObject powerPlantBackground = GameObject.Find("PowerPlantBackground");
        powerPlantBackground.SetActive(false);

        // Asteroid
        GameObject asteroidBackground = GameObject.Find("AsteroidBackground");
        asteroidBackground.SetActive(false);

        // Aquifer
        GameObject aquiferBackground = GameObject.Find("AquiferBackground");
        aquiferBackground.SetActive(false);

        // Greenery
        GameObject greeneryBackground = GameObject.Find("GreeneryBackground");
        greeneryBackground.SetActive(false);

        // City
        GameObject cityBackground = GameObject.Find("CityBackground");
        cityBackground.SetActive(false);
    }
}
