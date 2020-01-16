using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitPacking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string A = "110111";
        string B = "10001";
        string C = "1101";

        int aBits = Convert.ToInt32(A, 2);
        int bBits = Convert.ToInt32(B, 2);
        int cBits = Convert.ToInt32(C, 2);

        int packed = 0;

        packed = packed | (aBits << 32 - 6);
        packed = packed | (bBits << 32 - 6 - 5);
        packed = packed | (cBits << 32 - 6 - 5 - 4);

        Debug.Log(Convert.ToString(packed, 2).PadLeft(32, '0'));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
