﻿using iCat.Generate.IService;
using iCat.Generate.Model;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iCat.Generate.ServiceTest
{
    class TestServiceFileIervice
    {
        private IApplicationContext _springContext = null;
        [SetUp]
        public void Setup()
        {
            _springContext = ContextRegistry.GetContext();
        }
        [Test]
        public void TestServiceFileIService_GetCode()
        {
            #region
            IColumnsService columnsservice = (IColumnsService)_springContext
                .GetObject("columnsService");

            TableStructure tablestructure = new TableStructure();
            tablestructure._Name = "Order";
            tablestructure._Columns = columnsservice
                .GetColumns(tablestructure._Name);

            Namespace nspace = new Namespace(){
                _CustomSpring = "CustomSpring.Core",
                _FoundationCore = "Foundation.Core",
                _Prefix = "iCat.Generate"
            };

            Copyright copyright = new Copyright(){
                _Company = "iCat Studio",
                _Creater = "lhlfy",
                _Version = "V2.0"
            };

            IFileCreatorService fileservice = (IFileCreatorService)_springContext
                .GetObject("fileIServiceService");
            //fileservice.GetCode(tablestructure, nspace, copyright);
            #endregion
        }


    }
}
