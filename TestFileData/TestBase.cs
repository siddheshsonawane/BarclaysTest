using System;
using Xunit.Abstractions;
using AutoFixture;
using AutoFixture.AutoMoq;

namespace TestFileData
{
    public abstract class TestBase
    {
        protected IFixture Fixture { get; }

        public TestBase()
        {
            Fixture = new Fixture();//.Customize(new AutoMoqCustomization());
            
        }
    }
}
