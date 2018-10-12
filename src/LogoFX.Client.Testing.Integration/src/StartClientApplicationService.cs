using Attest.Testing.Contracts;
using LogoFX.Client.Testing.Contracts;

namespace LogoFX.Client.Testing.Integration
{
    /// <inheritdoc />
    public sealed class StartClientApplicationService : IStartClientApplicationService
    {
        private readonly IStartApplicationService _startApplicationService;

        /// <inheritdoc />
        public StartClientApplicationService(IStartApplicationService startApplicationService)
        {
            _startApplicationService = startApplicationService;
        }

        /// <inheritdoc />
        public void StartApplication()
        {
            _startApplicationService.StartApplication(string.Empty);
        }
    }
}