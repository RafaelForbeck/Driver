using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Image barImage;
    public float maxLife;
    
    private float currentLife;

    private void Start()
    {
        currentLife = maxLife;
        UpdateBar();
    }

    public void TakeDamage(float damage)
    {
        currentLife -= damage;
        currentLife = Mathf.Clamp(currentLife, 0, maxLife);
        UpdateBar();
        if (currentLife == 0)
        {
            // personagem morreu
            Destroy(gameObject);
        }
    }

    public void HealingHealth(float healing)
    {
        currentLife += healing;
        currentLife = Mathf.Clamp(currentLife, 0, maxLife);
        UpdateBar();
    }
         
    void UpdateBar()
    {
        barImage.fillAmount = currentLife / maxLife;
    }
}
