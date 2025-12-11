using System;
using System.Windows.Forms;
using Kpo.Services;
using Kpo.DataAccess.Xml;

namespace Kpo.WinFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            XmlPathProvider.CatalogPath = @"C:\Users\256bit.by\RiderProjects\Kpo\Kpo\catalog.xml";

            var categoryRepository = new XmlCatalogRepository();
            var facade = new ServiceFacade(categoryRepository);

            Application.Run(new MainForm(facade));
        }
    }
}