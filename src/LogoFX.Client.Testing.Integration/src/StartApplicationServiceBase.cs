using Attest.Testing.Core;
using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.Integration
{
    /// <summary>
    /// Represents start application service for integration tests.
    /// </summary>
    /// <seealso cref="IStartApplicationService" />    
    public class StartApplicationServiceBase : IStartApplicationService
    {
        /// <summary>
        /// Starts the application.
        /// </summary>
        /// <param name="startupPath">The startup path. In the integration tests case, it may be left empty.</param>
        public void StartApplication(string startupPath)
        {
            Setup();
            OnStartCore();
            OnStart(ScenarioHelper.RootObject);
        }

        /// <summary>
        /// Override this method to perform setup functionality before the application starts.
        /// </summary>
        protected virtual void Setup()
        {            
        }

        /// <summary>
        /// Override this method to inject custom logic with regard to the application root object 
        /// immediately after the object has been created.
        /// </summary>
        /// <param name="rootObject">The root object.</param>
        protected virtual void OnStart(object rootObject)
        {            
        }

        private static void OnStartCore()
        {
            ScenarioHelper.CreateRootObject();
        }
    }
}
