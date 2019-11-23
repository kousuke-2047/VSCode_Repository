using Util.BindingPropertyName;

namespace GridPointerName{
    public class GridPointer : BindingProperty{
        private int _pointerGridLeft;
        public int PointerGridLeft{
            get{
                return _pointerGridLeft;
            }
            set{
                this._pointerGridLeft = value;
                this.RaisePropertyChanged(nameof(PointerGridLeft));
            }
        }
        private int _pointerGridTop;
        public int PointerGridTop{
            get{
                return _pointerGridTop;
            }
            set{
                this._pointerGridTop = value;
                this.RaisePropertyChanged(nameof(PointerGridTop));
            }
        }

        private string _targetMenu;
        public string TargetMenu{
            get{
                return _targetMenu;
            }
            set{
                this._targetMenu = value;
                this.RaisePropertyChanged(nameof(TargetMenu));
            }
        }
    }
}