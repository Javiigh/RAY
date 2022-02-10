using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public int maxHealth = 5;
    int currentHealth;


    Rigidbody2D rigibody2d;

    void Start()
    {
        rigibody2d = GetComponent<Rigidbody2D>();

        currentHealth = maxHealth;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigibody2d.position;
        position.x = position.x + 30.0f * horizontal * Time.deltaTime;
        position.y = position.y + 30.0f * vertical * Time.deltaTime;

        rigibody2d.MovePosition(position);
    }

    void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
