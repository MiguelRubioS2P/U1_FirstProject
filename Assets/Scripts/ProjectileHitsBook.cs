using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHitsBook : MonoBehaviour
{

    public GameObject bookPrefabReference;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "book" || collision.gameObject.name == "book_0001a(Clone)")
        {

            Destroy(collision.gameObject);

            Instantiate(bookPrefabReference, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            float xOffset = Random.Range(-1, 1);
            bookPrefabReference.transform.Translate(
                new Vector3(xOffset,0,0)
                );
        }

    }

}
