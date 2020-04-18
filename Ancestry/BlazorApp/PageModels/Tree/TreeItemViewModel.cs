using Ancestry.AncestryDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ancestry.BlazorApp.PageModels
{
    public class TreeItemViewModel : ICloneable
    {
        private Node _item;
        public TreeItemViewModel()
        {
            _item = new Node();
        }
        public TreeItemViewModel(Node model)
        {
            _item = model;
        }
        public Node Item => _item;

        [Required]
        public int IdNode 
        { 
            get
            {
                return _item.IdNode;
            }
            set
            {
                _item.IdNode = value;
            }
        }
        [Required]
        public int NodeId
        {
            get
            {
                return _item.HumanId;
            }
            set
            {
                _item.HumanId = value;
            }
        }
        public string NodeIdString
        {
            get
            {
                return _item.HumanId.ToString();
            }
            set
            {
                _item.HumanId = Convert.ToInt32(value);
            }
        }
        public string NodeName { get; set; }
        public int? MotherId
        {
            get
            {
                return _item.MotherId;
            }
            set
            {
                _item.MotherId = value;
            }
        }
        public string MotherIdString
        {
            get
            {
                return _item.MotherId.ToString();
            }
            set
            {
                _item.MotherId = Convert.ToInt32(value);
            }
        }
        public string MotherName { get; set; }
        public int? FatherId
        {
            get
            {
                return _item.FatherId;
            }
            set
            {
                _item.FatherId = value;
            }
        }
        public string FatherIdString
        {
            get
            {
                return _item.FatherId.ToString();
            }
            set
            {
                _item.FatherId = Convert.ToInt32(value);
            }
        }
        public string FatherName { get; set; }
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
            TreeItemViewModel tempObject = (TreeItemViewModel)this.MemberwiseClone();
            tempObject._item = (Node)_item.Clone();
            return tempObject;
        }
    }
}
