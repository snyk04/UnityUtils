using System;
using System.Threading.Tasks;
using UnityEngine;

namespace UnityUtils.Other
{
    public static class TaskExtensions
    {
        public static async void CatchAndLog(this Task task)
        {
            try
            {
                await task;
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
            }
        }
    }
}