using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public Health health;
    public bool isDead;
}

public class Player:Character,IDamage
{
    
    public void takeDamage(int damage)
    {

    }
}
public interface IDamage
{
    void takeDamage(int damage);
}
