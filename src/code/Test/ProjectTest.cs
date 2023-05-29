using OpenQA.Selenium;
using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();



        [TestMethod]
        public void VerifyCreationProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("ProyectoLR");
            leftSite.addButton.Click();

            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("ProyectoLR"), "ERROR!The project was not created");

            Thread.Sleep(2000);
            leftSite.ClickProjectName("ProyectoLR");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("PLRUpdated");
            leftSite.saveButton.Click();

            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("PLRUpdated"), "ERROR!The project was not updated");


            leftSite.ClickProjectName("PLRupdated");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
        }

    }
}