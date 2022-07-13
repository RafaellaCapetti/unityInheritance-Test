using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public EnemyData enemyData;

    protected int _currentLife;

    protected virtual void Init()
    {
        _currentLife = enemyData.startLife;
    }
       
}
