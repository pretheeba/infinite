using System.Linq;
using System.Web.Mvc;
using NorthwindMVC;

public class CodeController : Controller
{
    private northwindEntities db = new northwindEntities(); 

    public ActionResult CustomersInGermany()
    {
        var customers = from c in db.Customers
                        where c.Country == "Germany"
                        select c;
        return View(customers.ToList());
    }

    public ActionResult CustomerWithOrder10248()
    {
        var order = (from o in db.Orders
                     where o.OrderID == 10248
                     select o).FirstOrDefault();

        if (order != null)
        {
            var customer = order.Customer;
            return View(customer);
        }
        return View(); 
    }
}
