using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ValidatorASPX
{
    public partial class Products : System.Web.UI.Page
    {
        // Dictionary to hold product information (name, image URL, price)
        private readonly Dictionary<string, (string ImageUrl, decimal Price)> _products = new Dictionary<string, (string ImageUrl, decimal Price)>
        {
            { "Product1", ("~/Images/img1.jpg", 10.99m) },
            { "Product2", ("~/Images/img2.jpg", 20.49m) },
            { "Product3", ("~/Images/img3.jpg", 15.75m) }
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the DropDownList with product names
                ddlProducts.DataSource = _products.Keys;
                ddlProducts.DataBind();
            }
        }
        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the Image control based on the selected product
            string selectedProduct = ddlProducts.SelectedValue;

            if (_products.TryGetValue(selectedProduct, out var productInfo))
            {
                imgProduct.ImageUrl = productInfo.ImageUrl;
            }
        }

        protected void btnGetPrice_Click(object sender, EventArgs e)
        {
            // Get the price of the selected product and display it in the Label
            string selectedProduct = ddlProducts.SelectedValue;

            if (_products.TryGetValue(selectedProduct, out var productInfo))
            {
                lblPrice.Text = $"Price: ${productInfo.Price:F2}";
            }
            else
            {
                lblPrice.Text = "Please select a valid product.";
            }
        }
    }
}