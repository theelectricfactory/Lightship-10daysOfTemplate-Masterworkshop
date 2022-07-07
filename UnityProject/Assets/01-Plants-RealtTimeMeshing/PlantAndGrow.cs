using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlantAndGrow : MonoBehaviour
{
    
    public GameObject[] plants;
    private GameObject plant;
    void Start()
    {
        // Instantiate( MODEL, PARENT )
        plant = Instantiate( getRandomPlant(), gameObject.transform);
        // Transform is the component that sets up position, rotation and scale
    }
    GameObject getRandomPlant() {

        int randomIndex = (int)Math.Floor(Random.Range(0f,1f)*plants.Length);
        return plants[randomIndex];
    }
    void Update()
    {
        
    }
}
