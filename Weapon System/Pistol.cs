using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : ManualWeapon
{
    private void Update()
    {
        Fire();
        Reload();
    }
}

