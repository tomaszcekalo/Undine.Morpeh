using Scellecs.Morpeh;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Morpeh
{
    public class MorpehSystem<A> : Core.ISystem, Scellecs.Morpeh.ISystem
        where A : struct
    {
        private Filter filter;
        public UnifiedSystem<A> System { get; set; }

        public World World { get ; set ; }

        public void Dispose()
        {
        }

        public void OnAwake()
        {
            this.filter = this.World.Filter
                .With<MorpehComponentWrapper<A>>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var entity in this.filter)
            {
                ref var aComponent = ref entity.GetComponent<MorpehComponentWrapper<A>>();
                System.ProcessSingleEntity(entity.ID.GetHashCode(), 
                    ref aComponent.value);
            }
        }

        public void ProcessAll()
        {
            OnUpdate(0);
        }
    }
    public class MorpehSystem<A, B> : Core.ISystem, Scellecs.Morpeh.ISystem
        where A : struct
        where B : struct
    {
        private Filter filter;

        public UnifiedSystem<A, B> System { get; set; }
        public World World { get; set; }

        public void Dispose()
        {
        }

        public void OnAwake()
        {
            this.filter = this.World.Filter
                .With<MorpehComponentWrapper<A>>()
                .With<MorpehComponentWrapper<B>>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var entity in this.filter)
            {
                ref var aComponent = ref entity.GetComponent<MorpehComponentWrapper<A>>();
                ref var bComponent = ref entity.GetComponent<MorpehComponentWrapper<B>>();
                System.ProcessSingleEntity(entity.ID.GetHashCode(), 
                    ref aComponent.value, 
                    ref bComponent.value);
            }
        }

        public void ProcessAll()
        {
            OnUpdate(0);
        }
    }
    public class MorpehSystem<A, B, C> : Core.ISystem, Scellecs.Morpeh.ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        private Filter filter;

        public UnifiedSystem<A, B, C> System { get; set; }

        public World World { get; set; }

        public void Dispose()
        {
        }

        public void OnAwake()
        {
            this.filter = this.World.Filter
                .With<MorpehComponentWrapper<A>>()
                .With<MorpehComponentWrapper<B>>()
                .With<MorpehComponentWrapper<C>>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var entity in this.filter)
            {
                ref var aComponent = ref entity.GetComponent<MorpehComponentWrapper<A>>();
                ref var bComponent = ref entity.GetComponent<MorpehComponentWrapper<B>>();
                ref var cComponent = ref entity.GetComponent<MorpehComponentWrapper<C>>();
                System.ProcessSingleEntity(entity.ID.GetHashCode(), 
                    ref aComponent.value, 
                    ref bComponent.value, 
                    ref cComponent.value);
            }
        }

        public void ProcessAll()
        {
            OnUpdate(0);
        }
    }
    public class MorpehSystem<A, B, C, D> : Core.ISystem, Scellecs.Morpeh.ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        private Filter filter;

        public UnifiedSystem<A, B, C, D> System { get; set; }

        public World World { get; set; }

        public void Dispose()
        {
        }

        public void OnAwake()
        {
            this.filter = this.World.Filter
                .With<MorpehComponentWrapper<A>>()
                .With<MorpehComponentWrapper<B>>()
                .With<MorpehComponentWrapper<C>>()
                .With<MorpehComponentWrapper<D>>()
                .Build();
        }

        public void OnUpdate(float deltaTime)
        {
            foreach (var entity in this.filter)
            {
                ref var aComponent = ref entity.GetComponent<MorpehComponentWrapper<A>>();
                ref var bComponent = ref entity.GetComponent<MorpehComponentWrapper<B>>();
                ref var cComponent = ref entity.GetComponent<MorpehComponentWrapper<C>>();
                ref var dComponent = ref entity.GetComponent<MorpehComponentWrapper<D>>();
                System.ProcessSingleEntity(entity.ID.GetHashCode(), 
                    ref aComponent.value, 
                    ref bComponent.value, 
                    ref cComponent.value,
                    ref dComponent.value);
            }
        }

        public void ProcessAll()
        {
            OnUpdate(0);
        }
    }
}
