using Net.Data;
using Net.Data.Infrastructure;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Main
{
   public  class TypeRegistery : Registry
    {
        public TypeRegistery()
        {
            For<IUnitOfWork<ApplicationContext>>().LifecycleIs(new UnitOfWork<ApplicationContext>).Use<ApplicationContext>();
        }
    }
}
