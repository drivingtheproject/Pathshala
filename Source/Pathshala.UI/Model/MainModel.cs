using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathshala.Main.Model
{
    public class MainModel : ViewModelBase {
        
        private string _status;

        public string Status {
            get {
                return _status;
            }
            set {
                base.SetProperty(ref _status, value);
            }
        }
        
        private string _title;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                base.SetProperty(ref _title, value);
            }
        }

        private string _productVersion;

        public string ProductVersion
        {
            get
            { 
                return _productVersion;
            }
            set
            {
                base.SetProperty(ref _productVersion, value);
            }
        }
    } 
}
