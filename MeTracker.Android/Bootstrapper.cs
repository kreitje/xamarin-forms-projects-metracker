using Autofac;
using MeTracker.Services;
using System;

namespace MeTracker.Droid
{
    public class Bootstrapper : MeTracker.Bootstrapper
    {
        public static void Init()
        {
            var instance = new Bootstrapper();
        }

        protected override void Initialize()
        {
            base.Initialize();

            ContainerBuilder.RegisterType<ILocationTrackingService>().As<ILocationTrackingService>().SingleInstance();
        }
    }
}
