using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    //Crear un GO

    public GameObject proyectilPrefabRef;
    float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        //creamos el objeto, cuando pulsemos la f para que no se nos creen tantos como los frames
        if (Input.GetKeyDown(KeyCode.F))
        {
            //instanciar un objeto creandolo desde un prefab 
            GameObject proyectil = Instantiate(proyectilPrefabRef, transform.position, Quaternion.identity);

            //añadiendo impulso al objeto cuando pulsamos a la F
            proyectil.GetComponent<Rigidbody>().AddForce(transform.forward * thrust, ForceMode.Impulse);

            //esto es para destruir los elementos creados por tiempo
            Destroy(proyectil, 5.0f);

        }

    }

}
