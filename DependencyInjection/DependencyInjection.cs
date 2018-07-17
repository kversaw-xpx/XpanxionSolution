using Unity;
using Unity.RegistrationByConvention;


namespace Xpanxion.IoC
{
   public class DependencyInjection
    {
        //This uses the ISomeClass = SomeClass convention to register the types. 
        //In the future when the dependancies get more complex code can be written to register the types from a config file.
        private static  UnityContainer container; 
        public static t ResolveDependency<t>()
        {
            if (container == null)
            {
                container = new UnityContainer();
                RegisterDependencies();
            }


            return container.Resolve<t>();
        }

        private static void RegisterDependencies()
        {
            container.RegisterTypes(
                AllClasses.FromAssembliesInBasePath(),
                WithMappings.FromMatchingInterface,
                WithName.Default);
        }
    }
}
