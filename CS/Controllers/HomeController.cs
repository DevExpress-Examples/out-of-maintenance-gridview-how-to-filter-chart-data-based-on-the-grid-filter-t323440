using System.Web.Mvc;
using DevExpress.Data.Filtering;

namespace GridViewChartFilterWeb.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial() {
            return PartialView(NorthwindDataProvider.GetProducts(null));
        }
        public ActionResult ChartPartial(string filterExpression) {
            string accessFilter = CriteriaToWhereClauseHelper.GetAccessWhere(CriteriaOperator.Parse(filterExpression));
            return PartialView(NorthwindDataProvider.GetProducts(accessFilter));
        }
    }
}
