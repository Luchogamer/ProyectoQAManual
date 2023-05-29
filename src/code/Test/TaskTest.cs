using OpenQA.Selenium;
using SeleniumTraining.src.code.page;
using SeleniumTraining.src.code.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.Test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        Projectsection projectsection = new Projectsection();



        [TestMethod]
        public void VerifyCreationProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("ProyectoLR");
            leftSite.addButton.Click();

            Thread.Sleep(2000);
            projectsection.TaskType.SetText("newTask");
            projectsection.DueDate.Click();
            projectsection.AddTask.Click();
            projectsection.CheckTask.Click();
        }
    }
}
