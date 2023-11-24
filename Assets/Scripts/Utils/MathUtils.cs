// PEACHYBAND CONFIDENTIAL
// __________________
// All Rights Reserved
// [2020]-[2023].

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Utils
{
    public static class MathUtils
    {
        public static List<Vector3> GetAvailable(Bounds bounds, 
            Vector3 position, float padding)
        {
            var result = new List<Vector3>();
            var xRow = GetDistance(bounds.min, bounds.max, Vector3.right);
            var zRow = GetDistance(bounds.min, bounds.max, Vector3.forward);

            for (var x = 0f; x < xRow; x += padding)
            {
                for (var z = 0f; z < zRow; z += padding)
                    result.Add(new Vector3(x, 0f, z) + position);
            }
            
            return result.ToList();
        }
        
        private static float GetDistance(Vector3 minPosition, 
            Vector3 maxPosition, Vector3 freezeAxis)
        {
            var convertedMin = new Vector3(minPosition.x * freezeAxis.x, 
                minPosition.y * freezeAxis.y,
                minPosition.z * freezeAxis.z);
            var convertedMax = new Vector3(maxPosition.x * freezeAxis.x, 
                maxPosition.y * freezeAxis.y,
                maxPosition.z * freezeAxis.z);
            return Vector3.Distance(convertedMin, convertedMax);
        }
    }
}