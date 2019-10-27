using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyParticle : MonoBehaviour
{
    public ParticleSystem ps;
    
    void Update () {
        //destroy particle system if it's not in use
        if(ps)
        {
            if(!ps.IsAlive())
            {
                Destroy(gameObject);
            }
        }
    }
}
