using System;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// Verifier ��ժҪ˵����
	/// </summary>
    public class DataVerify
	{
		public DataVerify()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		/// <summary>
		/// У���Ƿ�Ϊ���ڸ�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ����ڷ��ش���ֵ,�Ƿ����ڷ��ص�ǰ����ֵ</returns>
		static public DateTime VerifyDateTime(object Value){
			if(DBNull.Value.Equals(Value))
				return DateTime.Now;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return DateTime.Now;
					return DateTime.Parse(Value.ToString());
				}
				else
					return DateTime.Now;
			}
		}
		/// <summary>
		/// У���Ƿ�Ϊ�����͸�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ������ͷ��ش���ֵ,�Ƿ������ͷ�����</returns>
		static public long VerifyLong(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if((Value!=null)&&(Value.ToString()!="null"))
				{
					if(Value.ToString()=="")
						return 0;					
					return Int64.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// У���Ƿ�Ϊ�����͸�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ������ͷ��ش���ֵ,�Ƿ������ͷ�����</returns>
		static public short VerifyShort(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return Int16.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// У���Ƿ�Ϊ���͸�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ����ͷ��ش���ֵ,�Ƿ����ͷ�����</returns>
		static public int VerifyInt(object Value){
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return Int32.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}
		/// <summary>
		/// У���Ƿ�Ϊ�ַ���
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		static public string VerifyString(object Value){
			if(DBNull.Value.Equals(Value))
				return "";
			else
			{
				if(Value!=null)
					return Value.ToString();
				else
					return "";
			}
		}	
		/// <summary>
		/// У�鲼��ֵ
		/// </summary>
		/// <param name="Value"></param>
		/// <returns></returns>
		static public bool VerifyBool(object Value){
			if(DBNull.Value.Equals(Value))
				return false;
			else{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return false;

					if(Value.ToString()=="0")
						return false;
					if(Value.ToString()=="1")
						return true;

					return Boolean.Parse(Value.ToString());

				}
				else
					return false;
			}
		}

		/// <summary>
		/// У���Ƿ�Ϊdouble�͸�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ�double�ͷ��ش���ֵ,�Ƿ�double�ͷ�����</returns>
		static public double VerifyDouble(object Value)
		{
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return System.Double.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}

		/// <summary>
		/// У���Ƿ�Ϊsingle�͸�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ�single�ͷ��ش���ֵ,�Ƿ�single�ͷ�����</returns>
		static public float VerifySingle(object Value)
		{
			if(DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return System.Single.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}

		/// <summary>
		/// У���Ƿ�Ϊ�ֽڸ�ʽ
		/// </summary>
		/// <param name="Value">ҪУ���ֵ</param>
		/// <returns>�Ϸ��ֽڷ��ش���ֵ,�Ƿ��ֽڷ�����</returns>
		static public byte VerifyByte(object Value)
		{
			if(System.DBNull.Value.Equals(Value))
				return 0;
			else
			{
				if(Value!=null)
				{
					if(Value.ToString()=="")
						return 0;
					return byte.Parse(Value.ToString());
				}
				else
					return 0;
			}
		}


        /// <summary>
        /// ��Ҫ�����ж��Ƿ���1899-12-30 0001-1-1�ȷ�����������
        /// </summary>
        /// <param name="Value">������ô����Ѿ�֪�������ڸ�ʽ��ֵ</param>
        /// <returns>���������ڷ���true</returns>
        static public bool IsCorrectDate(object Value)
        {
            if (DBNull.Value.Equals(Value)) return false;
            if (Value == null) return false;
            if (Value.ToString().Length == 0) return false;
            string strDate = Convert.ToDateTime(Value).ToString("yyyy-MM-dd");
            if (strDate == "1899-12-30" || strDate == "0001-01-01") return false;

            return true;
        }

        static public bool IsCorrectDate(object Value, out string o_strDate)
        {
            o_strDate = "";
            bool isCorrect = IsCorrectDate(Value);
            if (isCorrect)
            {
                o_strDate = Convert.ToDateTime(Value).ToString("yyyy-MM-dd");
            }
            return isCorrect;
        }

        /// <summary>
        /// �ж��ǲ������ڸ�ʽ��ֵ
        /// </summary>
        /// <param name="Value">����δ֪��ʽ��ֵ</param>
        /// <returns></returns>
        static public bool IsDate(object Value)
        {
            if (DBNull.Value.Equals(Value)) return false;
            if (Value == null) return false;
            if (Value.ToString().Length == 0) return false;

            DateTime date;
            return DateTime.TryParse(Value.ToString(), out date);
        }

        /// <summary>
        /// ת����ö��ֵ
        /// </summary>
        /// <typeparam name="OutType">ö������</typeparam>
        /// <param name="Value">Ҫת����ֵ</param>
        /// <returns>����ö��</returns>
        static public OutType VerifyEnum<OutType>(object Value)
        {
            return (OutType)Enum.Parse(typeof(OutType), Value.ToString());
        }
	}
}
