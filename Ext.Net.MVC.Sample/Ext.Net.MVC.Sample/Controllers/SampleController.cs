using System.Web.Mvc;
using Ext.Net.MVC.Sample.Models;

namespace Ext.Net.MVC.Sample.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            SampleModel sm = new SampleModel()
            {
                WindowTitle = "Welcome to Ext.NET 2",
                TextAreaEmptyText = ">> Enter a Message Here <<"
            };

            return View(sm);
        }

        public ActionResult SampleAction(string msg)
        {
            X.Msg.Notify(new NotificationConfig
            {
                Icon = Icon.Accept,
                Title = "Working",
                Html = msg
            }).Show();

            return this.Direct();
        }
    }
}
