using System;

namespace FlowEnt
{
    public class EaseInExpo : IEasing
    {
        public float GetValue(float t)
            => (float)(t == 0 ? 0 : Math.Pow(2, 10 * t - 10));
    }
}