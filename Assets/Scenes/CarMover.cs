using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * This component moves the cars on the road
 */

public class CarMover : MonoBehaviour
{

    [SerializeField] public float Speed = 1;
    public void Init(Vector3 position, float speed )
    {
        transform.position = position;
        Speed = speed;

        gameObject.SetActive(true);
    }

    void Update()
    {
        transform.position -= new Vector3(Speed * Time.deltaTime, 0);

    }
}
   
    

