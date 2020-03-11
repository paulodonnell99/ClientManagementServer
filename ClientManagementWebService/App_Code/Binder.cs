using Autofac;
using ClientManagement.Data.Infrastructure;
using ClientManagement.Data.Repositories;
using ClientManagement.Service;
using ClientManagementWebService;

/// <summary>
/// Summary description for Binder
/// </summary>
public static class Binder
{
    public static IContainer Register()
    {
        var builder = new ContainerBuilder();

        //Register Webservices
        builder.RegisterType<SubscriptionWebService>().AsSelf();
        builder.RegisterType<ErrorReportingWebService>().AsSelf();

        //Register Service layer 
        builder.RegisterType<ClientService>().As<IClientService>();
        builder.RegisterType<SoftwareProfileService>().As<ISoftwareProfileService>();
        builder.RegisterType<ErrorReportingService>().As<IErrorReportingService>();

        //Register DB layer
        builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerLifetimeScope();
        builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        builder.RegisterType<ClientRepository>().As<IClientRepository>();
        builder.RegisterType<SoftwareProfileRepository>().As<ISoftwareProfileRepository>();
        builder.RegisterType<ErrorRepository>().As<IErrorRepository>();

        var container = builder.Build();

        return container;
    }
}