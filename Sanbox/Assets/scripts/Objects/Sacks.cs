using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sacks : MonoBehaviour
{
    public GameObject[] resources;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knife"))
        {
            Instantiate(resources[Random.Range(0, resources.Length)], transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            Instantiate(resources[Random.Range(0, resources.Length)], transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Debug.Log("xd");
        }
    }
}
