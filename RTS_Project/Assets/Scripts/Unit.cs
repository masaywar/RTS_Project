using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, IObserver, IUnit
{
    private IObservable _observable;

    [Header("Unit Common Attribute")]
    [SerializeField] private float _hp;
    [SerializeField] private float _mana;
    [SerializeField] private float _damage;
    [SerializeField] private float _speed;
    [SerializeField] private float _range;
    [SerializeField] private float _productingTime;

    private void OnEnable()
    {
        if (_observable != null)
        {
            _observable.Subscribe(this);
        }
    }


    public void BehaveUnique()
    {
        throw new System.NotImplementedException();
    }

    public void Invoke()
    {
        throw new System.NotImplementedException();
    }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void Stop()
    {
        throw new System.NotImplementedException();
    }
}
