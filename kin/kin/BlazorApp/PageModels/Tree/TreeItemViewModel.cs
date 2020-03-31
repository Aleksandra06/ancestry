using kin.TreeDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kin.BlazorApp.PageModels
{
    public class TreeItemViewModel : ICloneable
    {
        private Tree _item;
        public TreeItemViewModel()
        {
            _item = new Tree();
        }
        public TreeItemViewModel(Tree model)
        {
            _item = model;
        }
        public Tree Item => _item;

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
                return _item.NodeId;
            }
            set
            {
                _item.NodeId = value;
            }
        }
        public string NodeIdString
        {
            get
            {
                return _item.NodeId.ToString();
            }
            set
            {
                _item.NodeId = Convert.ToInt32(value);
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
            tempObject._item = (Tree)_item.Clone();
            return tempObject;
        }
    }
}
