// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using UnityEngine;

namespace Features.Observer.Views
{
    public class ObserverView : MonoBehaviour
    {
        [SerializeField] private Transform _observed;

        private void Update()
        {
            transform.LookAt(_observed);
        }
    }
}
