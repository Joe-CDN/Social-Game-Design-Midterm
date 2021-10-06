using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.tag.Equals("Player"))
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}
}
