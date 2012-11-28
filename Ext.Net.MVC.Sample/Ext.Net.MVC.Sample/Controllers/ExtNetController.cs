using System.Web.Mvc;
using Ext.Net.MVC.Sample.Models;

namespace Ext.Net.MVC.Sample.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult ExtNetIndex()
        {
            ExtNetModel sm = new ExtNetModel()
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
