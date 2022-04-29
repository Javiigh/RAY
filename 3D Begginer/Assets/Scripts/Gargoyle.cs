using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gargoyle : MonoBehaviour
{
    public Transform player;
    bool m_IsPlayerInRange;

    public GameEnding gameEnding;
    public GargoyleLight gargoyleLight;

    public float timer;
    float color = 0f;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {
        Debug.Log(timer);
        color = timer * 0.6f;

        if (m_IsPlayerInRange)
        {
            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);

            RaycastHit raycastHit;

            timer += Time.deltaTime;

            if (Physics.Raycast(ray, out raycastHit) && timer> 1.5f)
            {
                if (raycastHit.collider.transform == player)
                {
                    gameEnding.CaughtPlayer();
                }
            }
            else
            {
                gargoyleLight.Lantern(0);
            }
        }

        else
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
        }
        gargoyleLight.Lantern(color);
    }

    
}

