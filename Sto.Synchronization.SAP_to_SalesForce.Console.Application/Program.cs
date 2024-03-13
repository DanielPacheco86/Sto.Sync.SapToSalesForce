

using System;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Interface;
using Sto.Synchronization.SAP_to_SalesForce.Console.BusinessLogic.Factory;
using System.Threading.Tasks;
namespace Sto.Synchronization.SAP_to_SalesForce.Console.Application
{
    internal class Program
    {
        private static IServiceProvider _serviceProvider;
        static async Task Main(string[] args)
        {
            ConfigureServices();
            try
            {                
                IServiceScope scope = _serviceProvider.CreateScope();
                scope.ServiceProvider.GetRequiredService<FileManager>().Execute();
                DisposeServices();
            }
            catch (Exception ex)
            {   
                string message = ex.ToString();
            }
            
        }
        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<ISynchronizerCreator, SynchronizerCreator>();
            services.AddSingleton<FileManager>();

            _serviceProvider = services.BuildServiceProvider();
        }
        private static void DisposeServices()
        {
            if (_serviceProvider == null)
                return;

            if (_serviceProvider is IDisposable)
                ((IDisposable)_serviceProvider).Dispose();
        }
    }
}