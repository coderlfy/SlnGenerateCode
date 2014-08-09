﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCat.Generate.Model
{
    public class TableStructure
    {
        private string _name;

        public string _Name
        {
            get { return _name; }
            set { 
                _name = value;
                _paramNamePrefix = getParamPrefix();
                _nameLower = _name.ToLower();

            }
        }
        private string _nameLower;

        public string _NameLower
        {
            get { return _nameLower; }
        }
        
        private string _paramNamePrefix;

        public string _ParamNamePrefix
        {
            get { return _paramNamePrefix; }
            //set { _paramNamePrefix = value; }
        }
        

        private ColumnsData _columns;

        public ColumnsData _Columns
        {
            get { return _columns; }
            set { _columns = value; }
        }

        private List<string> _primaryKeys;

        public List<string> _PrimaryKeys
        {
            get { return _primaryKeys; }
            set { _primaryKeys = value; }
        }
        

        public TableStructure()
        {
            if (_columns == null)
                this._columns = new ColumnsData();
            if (_primaryKeys == null)
                this._primaryKeys = new List<string>();
        }

        private string getParamPrefix()
        {
            #region
            string prefix = "";
            if (this._name.Length == 1)
                prefix = this._name.ToLower();
            else
            {
                string first = this._name.Substring(0, 1).ToLower();
                string other = this._name.Substring(1, this._name.Length - 1);
                prefix = string.Format("{0}{1}", first, other);
            }
            return prefix;
            #endregion
        }
    }
}
