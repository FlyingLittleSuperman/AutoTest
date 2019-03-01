using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

namespace GisqRealEstate.ProDataSource
{
    public class WebPageBase:Page
    {
        private GisqLandProDataSource _objDataSource = null;
        protected GisqLandProDataSource objDataSource
        {
            get 
            {
                if (_objDataSource == null )
                {
                    _objDataSource = GisqLandProDataSourceFactory.CreateInstance();
                    if (_objDataSource == null)
                        throw new Exception("创建业务数据连接失败!");
                }
                _objDataSource.Open();
                return _objDataSource;
            }
        }
        public WebPageBase()
        {            
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        protected override void OnError(EventArgs e)
        {
            if (this._objDataSource != null)
            {
                _objDataSource.Close();
                _objDataSource.Dispose();
                _objDataSource = null;
            }
            base.OnError(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            if (_objDataSource != null)
            {
                _objDataSource.Close();
                _objDataSource.Dispose();
                _objDataSource = null;
            }
            base.OnUnload(e);
        }
    }
}
