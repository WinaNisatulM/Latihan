using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lat1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
      Debug.Log("Awake Dipanggil");
    }

    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Waktu untuk Update :" + Time.deltaTime);
    }

    void FixedUpdate()
    {
       Debug.Log("Waktu untuk FixedUpdate :" + Time.deltaTime);
    }

    void LateUpdate()
    {
     Debug.Log("Waktu untuk LateUpdate :" + Time.deltaTime);
    }

}

