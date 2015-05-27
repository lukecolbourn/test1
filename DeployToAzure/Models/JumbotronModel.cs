using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeployToAzure.Models
{
    public class JumbotronModel
    {
        public JumbotronModel(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}