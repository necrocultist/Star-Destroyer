using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : Health
{
    private Vector3 scaleChangeAmount = new Vector3(0.17f, 0.17f, 0f);
    [SerializeField] private GameManager gm;
    public GameObject[] healths;
    private int index = 0;

    public static event Action OnHealthDescreasement;
    public static event Action OnPlayerDie;

    protected override void OnEnable()
    {
        OnHealthDescreasement += ScaleChange;
    }
    
    public void DecraseHealth(int damage)
    {
        currentHealth -= damage;
        
        if (!AliveCheck())
        {
            DestroyObject();
            OnPlayerDie?.Invoke();
        }

        else
        {
            Destroy(healths[index]);
            index++;
        }
        OnHealthDescreasement?.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject gameObject = other.gameObject;

        if (gameObject != null)
        {
            if (gameObject.TryGetComponent(out EnemyHealth enemy) || gameObject.TryGetComponent(out EnemySpawner _))
            {
                enemy.DestroyObject();
                DecraseHealth(contactDamage);
            }
        }
        else
        {
            Debug.Log("There is no gameObject this" + name + "collides.");
        }
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    public void ScaleChange()
    {
        transform.localScale += scaleChangeAmount;
    }

    private void OnDisable()
    {
        OnHealthDescreasement -= ScaleChange;
    }
}
