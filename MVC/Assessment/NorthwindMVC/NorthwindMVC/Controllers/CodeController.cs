using System.Linq;
using System.Web.Mvc;
using NorthwindMVC;

public class CodeController : Controller
{
    private northwindEntities db = new northwindEntities(); 

    // Action Method to return all customers residing in Germany
    public ActionResult CustomersInGermany()
    {
        var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
        return View(customers);
    }

    // Action Method to return customer details with an OrderId == 10248
    public ActionResult CustomerWithOrder10248()
    {
        var order = db.Orders.FirstOrDefault(o => o.OrderID == 10248);
        if (order != null)
        {
            var customer = order.Customer;
            return View(customer);
        }
        return HttpNotFound();
    }
}
