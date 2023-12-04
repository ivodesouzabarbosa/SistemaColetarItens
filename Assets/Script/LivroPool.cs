using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivroPool : ItemPool
{
    public static LivroPool SharedInstance;

    protected override void Awake()
    {
        SharedInstance = this;
    }

}
