using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileOnHit : MonoBehaviour {

    // USE THIS SCRIPT ON OUR MUD PREFAB (The mud object sphere thing in our assets
    // folder. This basically removes the object if it collides with something that has OnTrigger
    // ticked (Which will only be our enemies.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
