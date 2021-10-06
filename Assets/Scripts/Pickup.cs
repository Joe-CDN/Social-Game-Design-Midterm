using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickup : MonoBehaviour
{
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }
    private void Update()
    {
        if(score == 100)
        {
            SceneManager.LoadScene("End");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Equals("Coin"))
        {
            score += 10;
            Destroy(collision.gameObject);
        }
    }
}
