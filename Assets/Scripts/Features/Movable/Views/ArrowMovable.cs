// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using Features.Movable.Base;
using UnityEngine;

namespace Features.Movable.Views
{
    public class ArrowMovable : BaseMovable
    {
        public override Vector3 CalculateDirection()
        {
            var horizontal = Input.GetAxis("HorizontalArrow");
            var vertical = Input.GetAxis("VerticalArrow");

            return new Vector3(vertical, 0f, horizontal);
        }
    }
}