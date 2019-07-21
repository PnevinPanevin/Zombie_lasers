using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicZombie : MonoBehaviour
{
    Animator anim;

    public float hp = 100;
    NavMeshAgent agent;  



    public void Damage(float dmg)
    {
        hp = hp - dmg;
    }

    void Death()
    {
        CapsuleCollider coll = transform.GetComponent<CapsuleCollider>();
        coll.enabled = false;
        agent.updatePosition = false;
        agent.angularSpeed = 0;
        agent.speed = 0;
        
        anim.SetTrigger("death");
        //anim.ResetTrigger("death");
        Invoke("destroy", 2);
    }
    public void Destination(Vector3 dest)
    {
        
        agent.SetDestination(dest);
    }

    void destroy()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Awake()
    {
        agent = transform.GetComponent<NavMeshAgent>();
        anim = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Death();
        }
       

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dest")
        {
            Death();
        }
    }

}
