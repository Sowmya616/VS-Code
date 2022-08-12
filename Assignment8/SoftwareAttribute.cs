using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_1
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
    internal class SoftwareAttribute : Attribute
    {
        private string projectName;
        private string description;
        private string clientName;
        private string startedDate;
        private string endDate;

        public string ProjectName { get { return ProjectName; } set { this.ProjectName = value; } }
        public string Description { get { return Description; } set { this.Description = value; } }
        public string ClientName { get { return ClientName; } set { this.ClientName = value; } }
        public string StartDate { get { return startedDate; } set { startedDate = value; } }
        public string EndDate { get { return endDate; } set { endDate = value; } }

        public SoftwareAttribute(string projectName, string description, string clientName, string startedDate, string endDate)
        {
            this.ProjectName = projectName;
            this.Description = description;
            this.ClientName = clientName;
            this.StartDate = startedDate;
            this.EndDate = endDate;
        }

        static void Main(string[] args)
        {
        }
    }
}
