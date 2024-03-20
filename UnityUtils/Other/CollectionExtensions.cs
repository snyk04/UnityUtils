using System.Collections.Generic;
using UnityEngine;

namespace UnityUtils.Other
{
    public static class CollectionExtensions
    {
        public static T GetRandom<T>(this IReadOnlyList<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}