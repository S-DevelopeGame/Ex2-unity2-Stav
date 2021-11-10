using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * This component destroy the player if the frog touch the car
 */
public class collisionPlayer : MonoBehaviour
{
    [SerializeField] string[] triggeringTag;
    [SerializeField] string nameScene;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == triggeringTag[0] && enabled)
        {
            SceneManager.LoadScene(nameScene);
        }
        if (other.tag == triggeringTag[1] && enabled)
        {
           Destroy(this.gameObject);
        }

    }
}
