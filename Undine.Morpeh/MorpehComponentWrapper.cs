using Scellecs.Morpeh;
using System;

namespace Undine.Morpeh
{
    public struct MorpehComponentWrapper<T> : IComponent where T : struct
    {
        public T value;

    }
}
