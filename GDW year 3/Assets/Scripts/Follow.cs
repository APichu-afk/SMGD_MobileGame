using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public int speed;
    public float close;
    private float attackcd = 1.0f;
    public Transform attackpoint;
    public int attackrange;
    public LayerMask humanlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        attackcd -= Time.deltaTime;

        if (Vector3.Distance(transform.position, player.position) >= close)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (attackcd <= 0)
        {
             attcked();
             attackcd = 1.0f;
        }
    }

    void attcked()
    {
        //Creates the hit box and checks what is being hit for the attack
        Collider[] hit = Physics.OverlapSphere(attackpoint.position, attackrange, humanlayer);

        foreach (Collider humans in hit)
        {
            Debug.Log("hit");
            humans.GetComponent<Attack>().healthdamage();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackpoint.position, attackrange);
    }
}
