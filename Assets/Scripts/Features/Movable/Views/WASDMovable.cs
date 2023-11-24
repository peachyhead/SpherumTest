// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using Features.Movable.Base;
using UnityEngine;

namespace Features.Movable.Views
{
    public class WASDMovable : BaseMovable
    {
        public override Vector3 CalculateDirection()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector3(vertical, 0f, horizontal);
        }
    }
}