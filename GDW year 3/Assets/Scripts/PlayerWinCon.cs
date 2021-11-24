using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWinCon : MonoBehaviour
{
    private int wincounter = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "SpacePart")
        {
            Destroy(other.gameObject);

            wincounter += 1;

            if (wincounter >= 6)
            {
                Debug.Log("You win");
            }
        }
    }
}
