using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Autofac;
using Autofac.Integration.Mvc;
using IOC.Interface;

namespace IOC.Test
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Register();
        }
        /// <summary>
        /// 负责调用autofac框架实现业务逻辑层和数据仓储层程序集中的类型对象的创建
        /// 负责创建MVC控制器类的对象(调用控制器中的有参构造函数),接管DefaultControllerFactory的工作
        /// </summary>
        public static void Register()
        {
            //实例化一个autofac的创建容器
            var builder = new ContainerBuilder();
            //告诉Autofac框架，将来要创建的控制器类存放在哪个程序集 (WebUI)
            Assembly controllerAss = Assembly.Load("IOC.Test");
            builder.RegisterControllers(controllerAss);

            //告诉autofac框架注册数据仓储层所在程序集中的所有类的对象实例(数据操作层)
            Assembly respAss = Assembly.Load("IOC.Factory");
            var respAssTypes = respAss.GetTypes();
            //创建respAss中的所有类的instance以此类的实现接口存储
            builder.RegisterTypes(respAssTypes).AsImplementedInterfaces();

            //注册带参数的接口实例
           // builder.RegisterType(respAssTypes.FirstOrDefault(x => x.Name.Contains("RoleService")))
            // .As<IRoleService>().InstancePerLifetimeScope().WithParameter("param", "adonis");

            //创建一个Autofac的容器
            var container = builder.Build();

 
            //将MVC的控制器对象实例 交由autofac来创建
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
