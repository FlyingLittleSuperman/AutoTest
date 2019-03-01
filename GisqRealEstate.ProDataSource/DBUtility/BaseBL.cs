using System;
using System.Collections.Generic;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
    public class BaseBL
    {
        /// <summary>
        /// 数据源对象，供子类直接访问的属性
        /// </summary>
        public GisqLandProDataSource objDataSource
        {
            get { return m_objDataSource; }
            set { m_objDataSource = value; }
        }
        private GisqLandProDataSource m_objDataSource;
        public BaseBL(GisqLandProDataSource p_objDataSource)
        {
            this.m_objDataSource = p_objDataSource;
        }
    }
}
