using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Slider slider;
    public Health planetHealth;
    // Start is called before the first frame update
    void Start()
    {
        planetHealth = GameObject.FindGameObjectWithTag("Planet").GetComponent<Health>();
        slider.maxValue = planetHealth.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = planetHealth.health;
    }
}
