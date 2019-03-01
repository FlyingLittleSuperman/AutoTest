using System;
using System.Collections.Generic;
using System.Text;

namespace GisqRealEstate.ProDataSource
{
    public class WebUCBase : System.Web.UI.UserControl
    {
        private GisqLandProDataSource _objDataSource = null;
        protected GisqLandProDataSource objDataSource
        {
            get
            {
                if (_objDataSource == null)
                {
                    _objDataSource = GisqLandProDataSourceFactory.CreateInstance();
                    if (_objDataSource == null)
                        throw new Exception("创建业务数据连接失败!");
                    _objDataSource.Open();
                }
                if (_objDataSource.State != System.Data.ConnectionState.Open)
                {
                    _objDataSource.Open();
                }
                return _objDataSource;
            }
        }
        public WebUCBase()
        {

        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            //objDataSource = GisqLandProDataSourceFactory.CreateInstance();

            //if (_objDataSource == null)
            //    throw new Exception("创建业务数据连接失败!");
            //objDataSource.Open();
        }

        protected override void OnError(EventArgs e)
        {
            if (this._objDataSource != null)
            {
                if (this._objDataSource.State == System.Data.ConnectionState.Open)
                    this._objDataSource.Close();
            }
            base.OnError(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            if (_objDataSource != null)
            {
                _objDataSource.Close();
                _objDataSource = null;
            }
            base.OnUnload(e);
        }
    }
}
