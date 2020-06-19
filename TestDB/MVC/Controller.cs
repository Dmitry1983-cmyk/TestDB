using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDB.MVC
{
    public class Controller
    {
        private static Controller controller = new Controller();
        private List<Model> models = new List<Model>();

        public static Controller GetController()
        {
            return controller;
        }

        public IEnumerable<Model> GetModels()
        {
            return models;
        }

        public void AddModels(Model model)
        {
            models.Add(model);
        }
    }
}