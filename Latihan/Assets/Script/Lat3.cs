using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lat3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int c = Jumlah(60, 40);
        Debug.Log("Hasil Jumlah a dan b adalah " + c);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    ///<summary>
    ///Merupakan fungsi penjumlahan dari 2 input angka
    ///</summary>
    ///<param name="a">Maskukan Angka Interger</param>
    ///<param name="b">Maskukan Angka Interger</param>
    ///Jumlah spesifikasi a dan b
     int Jumlah(int a, int b)
    {
        return a + b;
    }
}
