// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using System;
using Features.Movable.Base;
using UnityEngine;

namespace Features.Movable.Controllers
{
    public class MovableObserver : MonoBehaviour
    {
        [SerializeField] private float _lowerBound;
        [SerializeField] private float _bound;
        
        [SerializeField] private BaseMovable _movableA;
        [SerializeField] private BaseMovable _movableB;

        public delegate void MovableDistanceHandler(); 
        
        public event MovableDistanceHandler OnLowerBound;
        public event MovableDistanceHandler OnBound;
        public event MovableDistanceHandler OnUpperBound;
        public event MovableDistanceHandler OnDistanceChange;

        private float _movableDistance;

        private void Awake()
        {
            _movableDistance = _bound;
        }

        private void Update()
        {
            var distance = Vector3.Distance(_movableA.transform.position, 
                _movableB.transform.position);
            
            if (Mathf.Abs(_movableDistance - distance) > 0.0001f) 
                OnDistanceChange?.Invoke();
            _movableDistance = distance;
            
            if (_movableDistance <= _lowerBound)
                OnLowerBound?.Invoke();
            if (_movableDistance > _lowerBound && _movableDistance <= _bound)
                OnBound?.Invoke();
            else if (_movableDistance > _bound)
                OnUpperBound?.Invoke();
        }

        public float GetDistance() => _movableDistance;
    }
}