using Util.BindingPropertyName;
using ItemName;
using MapGraphicName;
using CanEquipName;
using System.Collections.Generic;

namespace UnitDataName{
    public class UnitData : BindingProperty{
        public int UnitID{get;set;}
        public string UnitName{get;set;}
        private int _unitGridLeft;
        public int UnitGridLeft{
            get{return _unitGridLeft;}
            set{this._unitGridLeft = value;
                this.RaisePropertyChanged(nameof(UnitGridLeft));
            }
        }
        private int _unitGridTop;
        public int UnitGridTop{
            get{return _unitGridTop;}
            set{this._unitGridTop = value;
                this.RaisePropertyChanged(nameof(UnitGridTop));
            }
        }
        private string _unitClass;
        public string UnitClass{
            get{return _unitClass;}
            set{this._unitClass = value;
                this.RaisePropertyChanged(nameof(UnitClass));
            }
        }
        public string UnitType{get;set;}
        private int _unitLevel;
        public int UnitLevel{
            get{return _unitLevel;}
            set{this._unitLevel = value;
                this.RaisePropertyChanged(nameof(UnitLevel));
            }
        }
        private int _unitExperience;
        public int UnitExperience{
            get{return _unitExperience;}
            set{this._unitExperience = value;
                this.RaisePropertyChanged(nameof(UnitExperience));
            }
        }
        private int _unitHP;
        public int UnitHP{
            get{return _unitHP;}
            set{this._unitHP = value;
                this.RaisePropertyChanged(nameof(UnitHP));
            }
        }
        private int _unitMaxHP;
        public int UnitMaxHP{
            get{return _unitMaxHP;}
            set{this._unitMaxHP = value;
                this.RaisePropertyChanged(nameof(UnitMaxHP));
            }
        }
        private int _unitPower;
        public int UnitPower{
            get{return _unitPower;}
            set{this._unitPower = value;
                this.RaisePropertyChanged(nameof(UnitPower));
            }
        }
        private int _unitMagic;
        public int UnitMagic{
            get{return _unitMagic;}
            set{this._unitMagic = value;
                this.RaisePropertyChanged(nameof(UnitMagic));
            }
        }
        private int _unitSkill;
        public int UnitSkill{
            get{return _unitSkill;}
            set{this._unitSkill = value;
                this.RaisePropertyChanged(nameof(UnitSkill));
            }
        }
        private int _unitSpeed;
        public int UnitSpeed{
            get{return _unitSpeed;}
            set{this._unitSpeed = value;
                this.RaisePropertyChanged(nameof(UnitSpeed));
            }
        }
        private int _unitLuck;
        public int UnitLuck{
            get{return _unitLuck;}
            set{this._unitLuck = value;
                this.RaisePropertyChanged(nameof(UnitLuck));
            }
        }
        private int _unitDefence;
        public int UnitDefence{
            get{return _unitDefence;}
            set{this._unitDefence = value;
                this.RaisePropertyChanged(nameof(UnitDefence));
            }
        }
        private int _unitMagicDefence;
        public int UnitMagicDefence{
            get{return _unitMagicDefence;}
            set{this._unitMagicDefence = value;
                this.RaisePropertyChanged(nameof(UnitMagicDefence));
            }
        }
        private int _unitMove;
        public int UnitMove{
            get{return _unitMove;}
            set{this._unitMove = value;
                this.RaisePropertyChanged(nameof(UnitMove));
            }
        }
        private int _unitLarge;
        public int UnitLarge{
            get{return _unitLarge;}
            set{this._unitLarge = value;
                this.RaisePropertyChanged(nameof(UnitLarge));
            }
        }
        private int _unitSaving;
        public int UnitSaving{
            get{return _unitSaving;}
            set{this._unitSaving=value;
                this.RaisePropertyChanged(nameof(UnitSaving));
            }
        }
        public int UnitMaxHPGrowth{get;set;}
        public int UnitPowerGrowth{get;set;}
        public int UnitMagicGrowth{get;set;}
        public int UnitSkillGrowth{get;set;}
        public int UnitSpeedGrowth{get;set;}
        public int UnitLuckGrowth{get;set;}
        public int UnitDefenceGrowth{get;set;}
        public int UnitMagicDefenceGrowth{get;set;}
        public string UnitFaceGraphic{get;set;}
        public MapGraphic UnitMapGraphic{get;set;}
        private string _unitTeam;
        public string UnitTeam{
            get{return _unitTeam;}
            set{this._unitTeam=value;
                this.RaisePropertyChanged(nameof(UnitTeam));
            }
        }
        private bool _unitMoveComplete;
        public bool UnitMoveComplete{
            get{return _unitMoveComplete;}
            set{this._unitMoveComplete = value;
                this.RaisePropertyChanged(nameof(UnitMoveComplete));
            }
        }
        public string UnitMoveType{get;set;}
        public List<Item> UnitItemList{get;set;}
        public CanEquip UnitCanEquip{get;set;}
        public int TotalPower{get;set;}
        public int TotalHit{get;set;}
        public int TotalDodge{get;set;}
        public int TotalCritical{get;set;}
        public int TotalSpeed{get;set;}





    }
}