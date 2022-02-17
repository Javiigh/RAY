using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // Función para cuando dos box colisionen

    void OnTriggerStay2D(Collider2D other)
    {
        // Recoge el gameobject ruby del script de Ruby
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
