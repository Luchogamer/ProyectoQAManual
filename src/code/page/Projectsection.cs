using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
	public class Projectsection
	{
		public TextBox TaskType = new TextBox(By.Id("//textarea[@id='NewItemContentInput']"));
		public Button DueDate = new Button(By.Id("//input[@id='AddItemAdvDate']"));
		public Button AddTask = new Button(By.Id("//input[@id='NewItemAddButton']"));
		public Button CheckTask = new Button(By.Id("//input[@id='ItemCheckBox']"));
	}
}

