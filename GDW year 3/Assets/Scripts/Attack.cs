using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    public Transform attackpointhuman;
    public int attackrange;
    public LayerMask monsterlayer;
    private int spawn;
    private Vector3 spawner1 = new Vector3(-40, 10, -40);//40, -37
    private Vector3 spawner2 = new Vector3(-65, 10, 44);//-65, 44
    private Vector3 spawner3 = new Vector3(-141, 10, 53);//-141, 53
    private Vector3 spawner4 = new Vector3(-211, 10, 2);//-211, 2
    private Vector3 spawner5 = new Vector3(-191, 10, -96);//-191, -96
    private Vector3 spawner6 = new Vector3(-111, 10, -114);//-111, -114
    private float health = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawn = Random.Range(1, 6);
        Debug.Log(health);
        if (health <=0)
        {
            SceneManager.LoadScene("EndScreen");
        }
    }

    void attack()
    {
        //Creates the hit box and checks what is being hit for the attack
        Collider[] hitmonsters = Physics.OverlapSphere(attackpointhuman.position, attackrange, monsterlayer);

        foreach (Collider monster in hitmonsters)
        {
            switch (spawn)
            {
                case 1:
                    monster.transform.position = spawner1;
                    break;
                case 2:
                    monster.transform.position = spawner2;
                    break;
                case 3:
                    monster.transform.position = spawner3;
                    break;
                case 4:
                    monster.transform.position = spawner4;
                    break;
                case 5:
                    monster.transform.position = spawner5;
                    break;
                case 6:
                    monster.transform.position = spawner6;
                    break;
            }
        }
        
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackpointhuman.position, attackrange);
    }

    public void healthdamage()
    {
        health -= 5.0f;
    }
}
