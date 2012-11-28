using System.Web.Mvc;
using Ext.Net.MVC.Sample.Models;

namespace Ext.Net.MVC.Sample.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult ExtNetIndex()
        {
            ExtNetModel model = new ExtNetModel()
            {
                WindowTitle = "Welcome to Ext.NET 2",
                TextAreaEmptyText = ">> Enter a Message Here <<"
            };

            return this.View(model);
        }

        public ActionResult SampleAction(string message)
        {
            X.Msg.Notify(new NotificationConfig
            {
                Icon = Icon.Accept,
                Title = "Working",
                Html = message
            }).Show();

            return this.Direct();
        }
    }
}
