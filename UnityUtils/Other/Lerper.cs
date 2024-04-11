using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityUtils.Other
{
    public static class Lerper
    {
        public static async Task To(Color startValue, Color goal, float duration, Action<Color> setter,
            CancellationToken cancellationToken)
        {
            await To(value => setter(Color.Lerp(startValue, goal, value)), duration, cancellationToken);
        }

        public static async Task To(Vector3 startValue, Vector3 goal, float duration, Action<Vector3> setter,
            CancellationToken cancellationToken)
        {
            await To(value => setter(Vector3.Lerp(startValue, goal, value)), duration, cancellationToken);
        }

        public static async Task To(float startValue, float goal, float duration, Action<float> setter,
            CancellationToken cancellationToken)
        {
            await To(value => setter(Mathf.Lerp(startValue, goal, value)), duration, cancellationToken);
        }

        public static async Task To(Action<float> setter, float duration, CancellationToken cancellationToken)
        {
            var startTime = Time.time;
            float progress = 0;
            while (progress < 1 && !cancellationToken.IsCancellationRequested)
            {
                progress = Mathf.InverseLerp(startTime, startTime + duration, Time.time);
                setter(progress);
                await Task.Yield();
            }
        }
    }
}