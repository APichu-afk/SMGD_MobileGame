using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterWinScript : MonoBehaviour
{
    private float health = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Debug.Log("Monsters win");
            SceneManager.LoadScene("EndScreen");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 2")
        {
            if (health <= 0)
            {

            }
            else
            {
                health -= 10.0f;
            }
            
        }
    }
}
