using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeleniumConfig.CommonClass.@interface
{
    public interface ISqlSchemaSelectInterface
    {
        void SqlSchemaSelectCallBack(String sqlSchemaId, String columnName);
    }
}
