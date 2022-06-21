using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarFill : MonoBehaviour
{
    void Start()
    {
    }
    public Image healthBarFill;

    public void FillUpdater(float currentHealth, float maxHealth) {
        healthBarFill.fillAmount = currentHealth / maxHealth;
        Debug.Log(healthBarFill.fillAmount);
    }
}
