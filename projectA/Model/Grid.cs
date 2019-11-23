using Util.BindingPropertyName;
using CostName;

namespace GridName{
    public class Grid : BindingProperty{
        public int GridLeft{get;set;}
        public int GridTop{get;set;}
        public int GridDefence{get;set;}
        public int GridDodge{get;set;}

        public Cost GridCost{get;set;}

        private bool _canmove;
        public bool Canmove{
            get{
                return _canmove;
            }
            set{
                this._canmove = value;
                this.RaisePropertyChanged(nameof(Canmove));
            }
        }
    }
}