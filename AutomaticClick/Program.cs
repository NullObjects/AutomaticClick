using System;
using System.IO;
using System.Windows.Forms;
using AutomaticClick.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutomaticClick
{
    static class Program
    {
        /// <summary>
        /// Program ServiceProvider
        /// </summary>
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        /// Program Configuration
        /// </summary>
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //构造配置
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            //构造服务
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            //启动界面
            if (ServiceProvider.GetRequiredService<ScreenShot>().ShowDialog() == DialogResult.OK)
                Application.Run(ServiceProvider.GetRequiredService<Main>());
        }

        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="services"></param>
        private static void ConfigureServices(IServiceCollection services)
        {
            //注册服务
            //注册Form
            services.AddTransient(typeof(Main));
            services.AddTransient(typeof(ScreenShot));
        }
    }
}