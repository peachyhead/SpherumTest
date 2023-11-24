// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using Features.Movable.Interfaces;
using UnityEngine;

namespace Features.Movable.Base
{
    public abstract class BaseMovable : MonoBehaviour, IMovable
    {
        [SerializeField] private float _speed;
        
        private void Update()
        {
            var direction = CalculateDirection();
            transform.Translate(direction * (_speed * Time.deltaTime));
        }

        public abstract Vector3 CalculateDirection();
    }
}