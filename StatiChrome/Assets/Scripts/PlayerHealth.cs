using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public int maxHealth = 120;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        slider.value = maxHealth;
        fill.color = gradient.Evaluate(1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }

    void takeDamage(int amount)
    {
        currentHealth -= amount;
        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);

        if (currentHealth <= 0) 
        { 
            // death();
        }
    }

    void heal(int amount)
    {
        currentHealth += amount;
        slider.value = currentHealth;
        fill.color = gradient.Evaluate(slider.normalizedValue);

        if (currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void death()
    {
        // Show Game over screen
    }
}
