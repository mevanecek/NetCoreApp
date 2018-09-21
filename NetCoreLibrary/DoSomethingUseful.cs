using System;

namespace NetCoreLibrary
{
    public class DoSomethingUseful
    {
        private string _organization;
        private string _project;

        public string ProjectName
        {
            get
            {
                return _project;
            }
            set
            {
                _project = value;
            }
        }

        public string Organization
        {
            get
            {
                return _organization;
            }
            set
            {
                _organization = value;
            }
        }

        public DoSomethingUseful() { }

        public override string ToString()
        {
            string s = "Organization : " + _organization;
            s += "\nProject      : " + _project;
            return s;
        }
    }
}
