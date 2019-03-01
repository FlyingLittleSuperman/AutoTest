using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SeleniumConfig.SQLConfig.Entity;

namespace SeleniumConfig.CommonClass.@interface
{
    public interface ISqlSchemaInterface
    {
        void SqlSchemaCallBack(SqlSchemaEntity sqlSchemaEntity);
    }
}
