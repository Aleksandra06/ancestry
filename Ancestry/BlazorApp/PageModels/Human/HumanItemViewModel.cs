using Ancestry.AncestryDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ancestry.BlazorApp.PageModels
{
    public class HumanItemViewModel : ICloneable
    {
        private Human _item;
        public HumanItemViewModel()
        {
            _item = new Human();
        }
        public HumanItemViewModel(Human model)
        {
            _item = model;
        }
        public Human Item => _item;

        [Required]
        public int IdName
        {
            get
            {
                return _item.IdName;
            }
            set
            {
                _item.IdName = value;
            }
        }
        [Required]
        [StringLength(20)]
        public string Name
        {
            get
            {
                return _item.Name;
            }
            set
            {
                _item.Name = value;
            }
        }
        [StringLength(20)]
        public string Surname
        {
            get
            {
                return _item.Surname;
            }
            set
            {
                _item.Surname = value;
            }
        }
        [StringLength(20)]
        public string MiddleName
        {
            get
            {
                return _item.MiddleName;
            }
            set
            {
                _item.MiddleName = value;
            }
        }
        public bool IsDeleted
        {
            get
            {
                return _item.IsDeleted;
            }
            set
            {
                _item.IsDeleted = value;
            }
        }
        public object Clone()
        {
            HumanItemViewModel tempObject = (HumanItemViewModel)this.MemberwiseClone();
            tempObject._item = (Human)_item.Clone();
            return tempObject;
        }
    }
}
