using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
    public int currentHp { get; private set; }
    public int maxHp {  get; private set; }
    public Health(int maxHp)
    {
        if(maxHp < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        this.maxHp = maxHp;
        this.currentHp = maxHp;
    }
    public void TakeDamage(int value)
    {
        if(value<0)
        {
            return;
        }
        if(currentHp >0)
        {
            currentHp = currentHp-value>0?currentHp-value:0;
        }
    }

}
