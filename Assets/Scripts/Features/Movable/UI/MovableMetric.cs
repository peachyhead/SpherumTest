// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using Features.Movable.Controllers;
using TMPro;
using UnityEngine;

namespace Features.Movable.UI
{
    public class MovableMetric : MonoBehaviour
    {
        [SerializeField] private MovableObserver _movableObserver;
        [SerializeField] private TMP_Text _distanceField;

        private void Start()
        {
            _movableObserver.OnDistanceChange += () =>
            {
                _distanceField.text = $"Distance : {_movableObserver.GetDistance()}";
            };
        }
    }
}