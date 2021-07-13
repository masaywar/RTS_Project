using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour, IBuilding, IObserver
{
    [Header("Producting Unit")]
    [SerializeField] IUnit _unit;

    private Queue<IUnit> _productQueue = new Queue<IUnit>();

    public void BehaveUnique()
    {
        throw new System.NotImplementedException();
    }

    public void Invoke()
    {
        throw new System.NotImplementedException();
    }

    public void ProductUnit()
    {
        if (_unit != null)
            _productQueue.Enqueue(_unit);
    }

    public void Stop()
    {
        if (_productQueue.Count > 0)
        {
            _productQueue.Dequeue();
        }
    }
}
