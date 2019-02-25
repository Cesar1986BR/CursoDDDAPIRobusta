using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using XGame.Domain.Interface.Repositories;
using XGame.Domain.Interface.Repositories.Base;
using XGame.Domain.Interface.Servico;
using XGame.Domain.Services;
using XGame.Infra2.Persistence;
using XGame.Infra2.Persistence.Repositories;
using XGame.Infra2.Persistence.Repositories.Base;
using XGame.Infra2.Transaction;

namespace XGame.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, XGameContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceJogador, ServiceJogador>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());
            


            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryJogador, RepositoryJogador>(new HierarchicalLifetimeManager());
             container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());
            
            

        }
    }
}
