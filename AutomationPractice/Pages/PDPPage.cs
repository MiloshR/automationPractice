﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.Pages
{
    class PDPPage
    {
        readonly IWebDriver driver;

        public By quantity = By.Id("quantity_wanted");
        public By addToCart = By.Id("add_to_cart");
        public By closePopUp = By.ClassName("cross");
        public By cartProduct = By.ClassName("ajax_cart_product_txt_s");
        public By productName = By.CssSelector(".pb-center-column [itemprop='name']");

        public PDPPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("columns")));
        }
    }
}
