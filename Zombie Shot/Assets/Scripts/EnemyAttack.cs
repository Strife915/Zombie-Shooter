using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 50f;
    private void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    public void AttackHitEvent()
    {
        if (target == null) return;
        target.Takedamage(damage);
        Debug.Log("Player get attacked");
    }

}
