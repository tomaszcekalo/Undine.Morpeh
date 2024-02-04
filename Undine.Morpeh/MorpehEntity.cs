using Scellecs.Morpeh;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Morpeh
{
    public class MorpehEntity : IUnifiedEntity
    {
        public Entity Entity { get; internal set; }

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.SetComponent<MorpehComponentWrapper<A>>(new MorpehComponentWrapper<A>()
            {
                value = component
            });
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref Entity.GetComponent<MorpehComponentWrapper<A>>().value;
        }

        public void RemoveComponent<A>() where A : struct
        {
            Entity.RemoveComponent<MorpehComponentWrapper<A>>();
        }
        public bool HasComponent<A>() where A : struct
        {
            return Entity.Has<MorpehComponentWrapper<A>>();
        }
    }
}