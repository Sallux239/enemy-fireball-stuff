using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    bool casting = false;
    public float currentPower = 0f;
    public float speed = 0.7f;
    void Start()
    {
        Destroy(gameObject, 3);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("start cast");
            casting = true;
            currentPower = 0f;

        }
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy);
        Destroy(gameObject);
    }
}
