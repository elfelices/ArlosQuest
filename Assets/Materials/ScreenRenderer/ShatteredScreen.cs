using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatteredScreen : MonoBehaviour
{
    public GameObject explosionPositionGO;
    public float explosionForce;
    private void Awake()
    {
        Vector3 explosionPosition = new Vector3();

        explosionPosition = explosionPositionGO.transform.position;

        foreach (Transform child in transform)
        {
            if (child.TryGetComponent<Rigidbody>(out Rigidbody childRigidbody))
            {
                childRigidbody.AddExplosionForce(explosionForce, explosionPosition, explosionForce);
            }
        }
    }
}
