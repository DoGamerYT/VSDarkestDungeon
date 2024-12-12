using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class BaseStats : MonoBehaviour

 {
    // Base stats
    public int strength = 10; // Determines physical damage
    public float speed = 5.0f; // Movement or action speed
    public float accuracy = 75.0f; // Percentage chance to hit
    public float critical = 10.0f; // Percentage chance for critical hit
    public float dodge = 15.0f; // Percentage chance to evade attacks

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Character Stats Initialized:");
        Debug.Log($"Strength: {strength}");
        Debug.Log($"Speed: {speed}");
        Debug.Log($"Accuracy: {accuracy}%");
        Debug.Log($"Critical: {critical}%");
        Debug.Log($"Dodge: {dodge}%");
    }

    // Methods to modify stats
    public void IncreaseStrength(int amount)
    {
        strength += amount;
        Debug.Log($"Strength increased! New Strength: {strength}");
    }

    public void IncreaseSpeed(float amount)
    {
        speed += amount;
        Debug.Log($"Speed increased! New Speed: {speed}");
    }

    public void IncreaseAccuracy(float amount)
    {
        accuracy += amount;
        if (accuracy > 100) accuracy = 100; // Cap accuracy at 100%
        Debug.Log($"Accuracy increased! New Accuracy: {accuracy}%");
    }

    public void IncreaseCritical(float amount)
    {
        critical += amount;
        if (critical > 100) critical = 100; // Cap critical at 100%
        Debug.Log($"Critical increased! New Critical: {critical}%");
    }

    public void IncreaseDodge(float amount)
    {
        dodge += amount;
        if (dodge > 100) dodge = 100; // Cap dodge at 100%
        Debug.Log($"Dodge increased! New Dodge: {dodge}%");
    }

    // Example for testing in Update (optional, for debugging purposes)
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            IncreaseStrength(5); // Press 1 to increase strength by 5
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            IncreaseSpeed(0.5f); // Press 2 to increase speed by 0.5
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            IncreaseAccuracy(5f); // Press 3 to increase accuracy by 5%
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            IncreaseCritical(5f); // Press 4 to increase critical by 5%
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            IncreaseDodge(5f); // Press 5 to increase dodge by 5%
        }
    }
}



/*{
   private int Strenght;
   private int speed;
   private int accuricy;
   private int critical;
   private int dodge;

   private float maxStrenght = 1000;
   private float maxSpeed = 250;
   private float maxAccuricy = 100;
   private float maxCritical = 100;
   private float maxDodge = 100;

   void Start()
   {

   }


   void Update()
   {

   }
}*/
