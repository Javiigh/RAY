using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        controller.isInvincible = true;
        controller.invincibleTimer -= Time.deltaTime;
        Destroy(gameObject);
        Debug.Log(controller.isInvincible);
    }
}
