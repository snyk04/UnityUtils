using UnityEngine;

namespace UnityUtils.Physics
{
    public static class PhysicsExtensions
    {
        public static bool RaycastUnderMouse(out RaycastHit hitInfo)
        {
            var camera = Camera.main;
            var ray = camera.ScreenPointToRay(Input.mousePosition);
            return UnityEngine.Physics.Raycast(ray, out hitInfo) ;
        }
    }
}