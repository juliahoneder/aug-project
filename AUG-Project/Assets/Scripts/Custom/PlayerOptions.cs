using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOptions : MonoBehaviour
{
    private int currentMegaCredit;

    // Start is called before the first frame update
    void Start()
    {
        currentMegaCredit = InitValues.currentMegaCredit;

        this.hideAllBackgrounds();
    }

    // Update is called once per frame
    void Update()
    {
        this.checkAllBackgrounds();
    }

    public void hideAllBackgrounds()
    {
        // Sell Plants
        GameObject sellPlantsBackground = GameObject.Find("SellPlantsBackground");
        sellPlantsBackground.GetComponent<Renderer>().enabled = false;

        // Power Plant
        GameObject powerPlantBackground = GameObject.Find("PowerPlantBackground");
        powerPlantBackground.GetComponent<Renderer>().enabled = false;

        // Asteroid
        GameObject asteroidBackground = GameObject.Find("AsteroidBackground");
        asteroidBackground.GetComponent<Renderer>().enabled = false;

        // Aquifer
        GameObject aquiferBackground = GameObject.Find("AquiferBackground");
        aquiferBackground.GetComponent<Renderer>().enabled = false;

        // Greenery
        GameObject greeneryBackground = GameObject.Find("GreeneryBackground");
        greeneryBackground.GetComponent<Renderer>().enabled = false;

        // City
        GameObject cityBackground = GameObject.Find("CityBackground");
        cityBackground.GetComponent<Renderer>().enabled = false;
    }

    public void checkAllBackgrounds()
    {
        currentMegaCredit = InitValues.currentMegaCredit;
   
        // City
        GameObject cityBackground = GameObject.Find("CityBackground");
        if (currentMegaCredit >= 25)
        {
            cityBackground.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            cityBackground.GetComponent<Renderer>().enabled = false;
        }
       
        // Greenery
        GameObject greeneryBackground = GameObject.Find("GreeneryBackground");
        if (currentMegaCredit >= 23)
        {
            greeneryBackground.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            greeneryBackground.GetComponent<Renderer>().enabled = false;
        }

        // Aquifer
        GameObject aquiferBackground = GameObject.Find("AquiferBackground");
        if (currentMegaCredit >= 18)
        {
            aquiferBackground.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            aquiferBackground.GetComponent<Renderer>().enabled = false;
        }

        // Asteroid
        GameObject asteroidBackground = GameObject.Find("AsteroidBackground");
        if (currentMegaCredit >= 14)
        {
            asteroidBackground.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            asteroidBackground.GetComponent<Renderer>().enabled = false;
        }

        // Power Plant
        GameObject powerPlantBackground = GameObject.Find("PowerPlantBackground");
        if (currentMegaCredit >= 11)
        {
            powerPlantBackground.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            powerPlantBackground.GetComponent<Renderer>().enabled = false;
        }
    }
}
