using OpenQA.Selenium;
using Selenium.Support;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Selenium.Pages
{
    class swagLab: TestPage
    {
        public swagLab(IWebDriver webDriver)
        {
            Setup(webDriver);
            Name = PageName.swagLab;
            Url = "https://www.saucedemo.com/";
        }

        protected sealed override Collection<Locator> InitializeLocators()
        {
            return new Collection<Locator>
            {
                new Locator(Element.swagLabUserName, By.Id("user-name")),
                new Locator(Element.swagLabPassword, By.Name("password")),
                new Locator(Element.swagLabLoginButton, By.Id("login-button")),
                new Locator(Element.swaglabLoginErrorText, By.XPath("//h3[@data-test='error']")),
                new Locator(Element.swagLabLoginHeader, By.XPath("//span[@class='title']")),
                new Locator(Element.swagLabInventoryItemName, By.XPath("//div[@class='inventory_item_name']")),
                new Locator(Element.swagLabShoppingCartContainer, By.XPath("//a[@class='shopping_cart_link']")),
                new Locator(Element.swagLabAddToCartBackPack, By.Id("add-to-cart-sauce-labs-backpack")),
                new Locator(Element.swagLabAddToCartBikeLight, By.Id("add-to-cart-sauce-labs-bike-light")),
                new Locator(Element.swagLabAddToCartBoltTShirt, By.Id("add-to-cart-sauce-labs-bolt-t-shirt")),
                new Locator(Element.swagLabAddToCartFleeceJacket, By.Id("add-to-cart-sauce-labs-fleece-jacket")),
                new Locator(Element.swagLabAddToCartOnesie, By.Id("add-to-cart-sauce-labs-onesie")),
                new Locator(Element.swagLabAddTShirtRed, By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")),
            };
        }
    }
}

