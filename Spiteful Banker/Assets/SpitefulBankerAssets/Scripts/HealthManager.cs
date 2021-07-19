using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class HealthManager : MonoBehaviour
{
    [Range(0, 50)] public float health;
    public UnityEvent onDeath;
    public TextMeshProUGUI healthText;
    public void Start()
    {
        health = 50;
    }
    public void TakeDamage(float _damage)
    {
        health -= _damage;
        HandelDeath();
    }
    void HandelDeath()
    {
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        onDeath.Invoke();
    }
}