using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarFill : MonoBehaviour
{
    void Start()
    {
        FillUpdater();
    }
    private Image healthBarFill;

    public void FillUpdater() {
        healthBarFill.fillAmount = 0.5f;
        Debug.Log(healthBarFill.fillAmount);
    }
}
