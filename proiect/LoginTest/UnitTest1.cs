using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Windows.Forms;
using proiect;


namespace TestingProject

{
    //Marian Flaminzanu-Mateiuc
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void LoginTest_ShouldPassIfCredentialsAreCorrect()
        {
            //se introduc credentiale corecte
            var loginForm = new LoginForm();
            loginForm.Username = "marian";
            loginForm.Password = "marian";

            loginForm.Login();

            //testul trece deoarece utilizatorul exista
            Assert.AreEqual(loginForm.LoggedIn, 1);

        }

        [TestMethod]
        public void LoginTest_ShouldPassIfCredentialsAreNotCorrect()
        {
            var loginForm = new LoginForm();
            loginForm.Username = "marian";
            loginForm.Password = "georgica";

            loginForm.Login();

            //testul trece deoarece utilizatorul nu exista

            Assert.AreNotEqual(loginForm.LoggedIn, 1);
        }
    }


    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public void SearchTest_SearchRestaurantsInExistingCity()
        {
            //se introduce valoare in ComboBox
            var searchForm = new SearchForm();
            searchForm.City = "Iasi";
            searchForm.SearchCity();

            //testul trece deoarece exista restaurante in acest oras
            Assert.IsFalse(searchForm.isDatabaseEmpty);

        }


        [TestMethod]

        public void SearchTest_SearchRestaurantsInNotExistingCity()
        {
            var searchForm = new SearchForm();
            searchForm.City = "Hunedoara";

            searchForm.SearchCity();
            //testul trece deoarece nu exista acest oras

            Assert.IsTrue(searchForm.isDatabaseEmpty);

        }
    }
}