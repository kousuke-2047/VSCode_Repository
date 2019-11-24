using Util.BindingPropertyName;

namespace StatusWindowName{
    public class StatusWindow : BindingProperty{
        private string _unitName;
        public string UnitName{
            get{return _unitName;}
            set{this._unitName=value;
                this.RaisePropertyChanged(nameof(UnitName));
            }
        }
    }
}