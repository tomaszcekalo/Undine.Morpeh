using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;
using Undine.Morpeh.Tests.Components;

namespace Undine.Morpeh.Tests
{
    [TestClass]
    public class ContainerTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void EntityCanBeCreated()
        {
            var container = new MorpehContainer();
            container.Init();
            var entity = container.CreateNewEntity();
            Assert.IsNotNull(entity);
        }
        [TestMethod]
        public void EntityCanBeDeleted()
        {
            var container = new MorpehContainer();
            container.Init();
            var entity = container.CreateNewEntity();
            container.DeleteEntity(entity);
        }

        [TestMethod]
        public void OneTypeSystemCanBeAdded()
        {
            var container = new MorpehContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeAdded()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent>>();
            var container = new MorpehContainer();
            container.AddSystem(mock);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeAdded()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new MorpehContainer();
            container.AddSystem(mock);
        }

        [TestMethod]
        public void FourTypeSystemCanBeAdded()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new MorpehContainer();
            container.AddSystem(mock);
        }

        [TestMethod]
        public void OneTypeSystemCanBeRetrieved()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            var container = new MorpehContainer();
            container.GetSystem(mock);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeRetrieved()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent>>();
            var container = new MorpehContainer();
            container.GetSystem(mock);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeRetrieved()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new MorpehContainer();
            container.GetSystem(mock);
        }

        [TestMethod]
        public void FourTypeSystemCanBeRetrieved()
        {
            var mock = Substitute.For<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new MorpehContainer();
            container.GetSystem(mock);
        }
    }
}
