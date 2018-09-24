using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    public GameObject projectile;

	// Update is called once per frame
	public void ShootProj()
    {
        GameObject mudProj = Instantiate(projectile, transform) as GameObject;
        Rigidbody rb = mudProj.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * 20;
    }
}
