using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public GameObject healthBar;
    public float maxHealth;
    public float currentHealth;
    HealthBarFill healthBarFill;
    // Start is called before the first frame update
    void Start()
    {
        healthBarFill = GetComponent<HealthBarFill>();
        currentHealth = maxHealth;
    }

    void Update()
    {
        healthBarFill.FillUpdater();
    }

    public void Heal(int amount) {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }

    public void Damage (int amount) {
        currentHealth -= amount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        UpdateHealthBar();
    }

    public void UpdateHealthBar() {
        healthBar.transform.localScale = new Vector3(
            currentHealth * 1f / maxHealth * 1f,
            healthBar.transform.localScale.y,
            healthBar.transform.localScale.z
        );
    }
}
