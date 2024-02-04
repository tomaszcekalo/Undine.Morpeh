using Scellecs.Morpeh;
using System;
using Undine.Core;

namespace Undine.Morpeh
{
    public class MorpehContainer : EcsContainer
    {
        public MorpehContainer()
        {
            World = World.Create();
            SystemsGroup = World.CreateSystemsGroup();
        }
        public World World { get; set; }
        public SystemsGroup SystemsGroup { get; set; }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            SystemsGroup.AddSystem(new MorpehSystem<A>()
            {
                World = this.World,
                System = system
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            SystemsGroup.AddSystem(new MorpehSystem<A, B>()
            {
                World = this.World,
                System = system
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            SystemsGroup.AddSystem(new MorpehSystem<A, B, C>()
            {
                World = this.World,
                System = system
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            SystemsGroup.AddSystem(new MorpehSystem<A, B, C, D>()
            {
                World = this.World,
                System = system
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new MorpehEntity()
            {
                Entity = this.World.CreateEntity()
            };
        }

        public override void DeleteEntity(IUnifiedEntity entity)
        {
            var entityToRemove = entity as MorpehEntity;
            if(entityToRemove is not null)
            {
                this.World.RemoveEntity(entityToRemove.Entity);
            }

        }

        public override Core.ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new MorpehSystem<A>()
            {
                World = this.World,
                System = system
            };
        }

        public override Core.ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new MorpehSystem<A, B>()
            {
                World = this.World,
                System = system
            };
        }

        public override Core.ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new MorpehSystem<A, B, C>()
            {
                World = this.World,
                System = system
            };
        }

        public override Core.ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new MorpehSystem<A, B, C, D>()
            {
                World = this.World,
                System = system
            };
        }

        public override void Run()
        {
            SystemsGroup.Update(0);
        }
    }
}
