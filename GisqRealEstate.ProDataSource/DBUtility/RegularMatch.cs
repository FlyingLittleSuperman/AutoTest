using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace GisqRealEstate.ProDataSource
{
	/// <summary>
	/// RegularMatch ��ժҪ˵����
	/// </summary>
	public class RegularMatch
	{
		private string _String;
		private bool _IsEntirety;


		public RegularMatch( )
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
//			_String = strString;
		}

		

        /**//// <summary>
        /// ���Խ����жϵ�����
        /// </summary>
        public enum Operation
        {
            Byte, SByte, Int16, Int32, Int64, Single, Double, Boolean, Char, Decimal, DateTime, Date, Time,
            EMail, URL, ChinaPhone, ChineseWord, ChinesePostalCode, Number, StringModel_01, StringModel_02, WideWord, NarrowWord, IPAddress,
            ChineseMobile, ChineseID
        };

       

        #region �����ж��ַ����Ƿ��Ƕ�Ӧ���ͣ�Ĭ��Ϊ����ƥ�䣩
        public  bool IsAccordType(string strVerifyString, Operation op)
        {
            return IsAccordType(strVerifyString, op, false);
        }
        #endregion

        #region �����ж��ַ����Ƿ��Ƕ�Ӧ���ͣ����Ƿ������Ӧ���͵��ַ���
        /**//// <summary>
        /// �����ж��ַ����Ƿ��Ƕ�Ӧ����
        /// </summary>
        /// <param name="strVerifyString">String����Ҫ�жϵ��ַ���</param>
        /// <param name="op">Operationö�٣�����ѡ����Ҫ���еĲ���</param>
        /// <param name="IsEntirety">Boolean���ж�����ȫƥ�仹�ǰ���ƥ��ģʽ���������ڷ������ж�ʱ��</param>
        /// <returns></returns>
        public  bool IsAccordType(string strVerifyString, Operation op, bool IsEntirety)
        {
            _String = strVerifyString;
            _IsEntirety = IsEntirety;

            switch (op)
            {
                case Operation.Byte:
                    {
                        return IsByte();
                    }
                case Operation.SByte:
                    {
                        return IsSByte();
                    }
                case Operation.Int16:
                    {
                        return IsInt16();
                    }
                case Operation.Int32:
                    {
                        return IsInt32();
                    }
                case Operation.Int64:
                    {
                        return IsInt64();
                    }
                case Operation.Single:
                    {
                        return IsSingle();
                    }
                case Operation.Double:
                    {
                        return IsDouble();
                    }
                case Operation.Boolean:
                    {
                        return IsBoolean();
                    }
                case Operation.Char:
                    {
                        return IsChar();
                    }
                case Operation.Decimal:
                    {
                        return IsDecimal();
                    }
                case Operation.DateTime:
                    {
                        return IsDateTime();
                    }
                case Operation.Date:
                    {
                        return IsDate();
                    }
                case Operation.Time:
                    {
                        return IsTime();
                    }
                case Operation.IPAddress:
                    {
                        return IsIPAddress();
                    }
                case Operation.ChinaPhone:
                    {
                        return IsChinaPhone();
                    }
                case Operation.ChinesePostalCode:
                    {
                        return IsChinesePostalCode();
                    }
                case Operation.ChineseMobile:
                    {
                        return IsChineseMobile();
                    }
                case Operation.EMail:
                    {
                        return IsEmail();
                    }
                case Operation.URL:
                    {
                        return IsURL();
                    }
                case Operation.ChineseWord:
                    {
                        return IsChineseWord();
                    }
                case Operation.Number:
                    {
                        return IsNumber();
                    }
                case Operation.StringModel_01:
                    {
                        return IsStringModel_01();
                    }
                case Operation.StringModel_02:
                    {
                        return IsStringModel_02();
                    }
                case Operation.WideWord:
                    {
                        return IsWideWord();
                    }
                case Operation.NarrowWord:
                    {
                        return IsNarrowWord();
                    }
                case Operation.ChineseID:
                    {
                        return IsChineseID();
                    }
                default:
                    {
                        return false;
                    }
            }
        }
        #endregion

        #region ������֤����

        #region �Ƿ�Byte���ͣ�8 λ���޷����������� 0 �� 255 ֮����޷�������
        /**//// <summary>
        /// �Ƿ�Byte���ͣ�8 λ���޷����������� 0 �� 255 ֮����޷�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsByte()
        {
            try
            {
                Byte.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�SByte���ͣ�8 λ���з����������� -128 �� +127 ֮�������
        /**//// <summary>
        /// �Ƿ�SByte���ͣ�8 λ���з����������� -128 �� +127 ֮�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsSByte()
        {
            try
            {
                SByte.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Int16���ͣ�16 λ���з����������� -32768 �� +32767 ֮����з�������
        /**//// <summary>
        /// �Ƿ�Int16���ͣ�16 λ���з����������� -32768 �� +32767 ֮����з�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsInt16()
        {
            try
            {
                Int16.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Int32���ͣ�32 λ���з�����������-2,147,483,648 �� +2,147,483,647 ֮����з�������
        /**//// <summary>
        /// �Ƿ�Int32���ͣ�32 λ���з�����������-2,147,483,648 �� +2,147,483,647 ֮����з�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsInt32()
        {
            try
            {
                Int32.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Int64���ͣ�64 λ���з����������� -9,223,372,036,854,775,808 �� +9,223,372,036,854,775,807 ֮�������
        /**//// <summary>
        /// �Ƿ�Int64���ͣ�64 λ���з����������� -9,223,372,036,854,775,808 �� +9,223,372,036,854,775,807 ֮�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsInt64()
        {
            try
            {
                Int64.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Single���ͣ������ȣ�32 λ���������֣��� -3.402823e38 �� +3.402823e38 ֮��ĵ����� 32 λ����
        /**//// <summary>
        /// �Ƿ�Single���ͣ������ȣ�32 λ���������֣��� -3.402823e38 �� +3.402823e38 ֮��ĵ����� 32 λ����
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsSingle()
        {
            try
            {
                Single.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Double���ͣ������ȣ�64 λ���������֣��� -1.79769313486232e308 �� +1.79769313486232e308 ֮���˫���� 64 λ����
        /**//// <summary>
        /// �Ƿ�Double���ͣ������ȣ�64 λ���������֣��� -1.79769313486232e308 �� +1.79769313486232e308 ֮���˫���� 64 λ����
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsDouble()
        {
            try
            {
                Double.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Boolean���ͣ�����ֵ����true �� false
        /**//// <summary>
        /// �Ƿ�Double���ͣ������ȣ�64 λ���������֣��� -1.79769313486232e308 �� +1.79769313486232e308 ֮���˫���� 64 λ����
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsBoolean()
        {
            try
            {
                Boolean.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Char���ͣ�Unicode��16 λ���ַ������� 16 λ���ֵ�ֵ��ΧΪ��ʮ������ֵ 0x0000 �� 0xFFFF
        /**//// <summary>
        /// �Ƿ�Char���ͣ�Unicode��16 λ���ַ������� 16 λ���ֵ�ֵ��ΧΪ��ʮ������ֵ 0x0000 �� 0xFFFF
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsChar()
        {
            try
            {
                Char.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Char���ͣ�96 λʮ����ֵ�������� 79,228,162,514,264,337,593,543,950,335 ���� 79,228,162,514,264,337,593,543,950,335 ֮���ʮ������
        /**//// <summary>
        /// �Ƿ�Char���ͣ�96 λʮ����ֵ�������� 79,228,162,514,264,337,593,543,950,335 ���� 79,228,162,514,264,337,593,543,950,335 ֮���ʮ������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsDecimal()
        {
            try
            {
                Decimal.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�DateTime���ͣ���ʾʱ���ϵ�һ�̣��� ��Χ�ڹ�Ԫ��������Ԫ��0001 �� 1 �� 1 ����ҹ 12:00:00 ����Ԫ (C.E.) 9999 �� 12 �� 31 ������ 11:59:59 ֮������ں�ʱ��
        /**//// <summary>
        /// �Ƿ�DateTime���ͣ���ʾʱ���ϵ�һ�̣��� ��Χ�ڹ�Ԫ��������Ԫ��0001 �� 1 �� 1 ����ҹ 12:00:00 ����Ԫ (C.E.) 9999 �� 12 �� 31 ������ 11:59:59 ֮������ں�ʱ��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsDateTime()
        {
            try
            {
                DateTime.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ�Date���ͣ���ʾʱ������ڲ��֣��� ��Χ�ڹ�Ԫ��������Ԫ��0001 �� 1 �� 1 �� ����Ԫ (C.E.) 9999 �� 12 �� 31 ��֮�������
        /**//// <summary>
        /// �Ƿ�Date���ͣ���ʾʱ������ڲ��֣��� ��Χ�ڹ�Ԫ��������Ԫ��0001 �� 1 �� 1 �� ����Ԫ (C.E.) 9999 �� 12 �� 31 ��֮�������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsDate()
        {
            DateTime Value;
            try
            {
                Value = DateTime.Parse(_String);
            }
            catch
            {
                return false;
            }
            if (Value.Date.ToString() == _String)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region �Ƿ�Time���ͣ���ʾʱ�䲿��HHMMSS���� ��Χ��ҹ 12:00:00 ������ 11:59:59 ֮���ʱ��
        /**//// <summary>
        /// �Ƿ�Time���ͣ���ʾʱ�䲿��HHMMSS���� ��Χ��ҹ 12:00:00 ������ 11:59:59 ֮���ʱ��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsTime()
        {
            DateTime Value;
            try
            {
                Value = DateTime.Parse(_String);
            }
            catch
            {
                return false;
            }
            if (Value.Year == 1 && Value.Month == 1 && Value.Day == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region �Ƿ�IPAddress���ͣ�IPv4 �������ʹ���Ե�ָ����Ĳ��ֱ�ʾ����ʽ��ʾ��IPv6 �������ʹ��ð����ʮ�����Ƹ�ʽ��ʾ��
        /**//// <summary>
        /// �Ƿ�IPAddress���ͣ�IPv4 �������ʹ���Ե�ָ����Ĳ��ֱ�ʾ����ʽ��ʾ��IPv6 �������ʹ��ð����ʮ�����Ƹ�ʽ��ʾ��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsIPAddress()
        {
            try
            {
                System.Net.IPAddress.Parse(_String);
            }
            catch
            {
                return false;
            }
            return true;
        }
        #endregion

        #region �Ƿ��й��绰�������ͣ�XXX/XXXX-XXXXXXX/XXXXXXXX (\d{3,4})-?\d{7,8}�����ж��Ƿ��ǣ����ţ�3��4λ��-���绰���룺7��8λ��
        /**//// <summary>
        /// �Ƿ��й��绰�������ͣ�XXX/XXXX-XXXXXXX/XXXXXXXX (\d{3,4})-?\d{7,8}�����ж��Ƿ��ǣ����ţ�3��4λ��-���绰���룺7��8λ��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsChinaPhone()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"(\d{3,4})-?\d{7,8}", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ��й��������루6λ���� \d{6}��
        /**//// <summary>
        /// �Ƿ��й��������루6λ���� \d{6}��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsChinesePostalCode()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"\d{6}", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ��й��ƶ��绰���루13��ͷ����11λ���� 13\d{9}��
        /**//// <summary>
        /// �Ƿ��й��ƶ��绰���루13��ͷ����11λ���� 13\d{9}��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsChineseMobile()
        {
            ArrayList aryResult = new ArrayList();
            return (CommRegularMatch(_String, @"13\d{9}", RegexOptions.None, ref aryResult, _IsEntirety)
                || CommRegularMatch(_String, @"15\d{9}", RegexOptions.None, ref aryResult, _IsEntirety)
                || CommRegularMatch(_String, @"18\d{9}", RegexOptions.None, ref aryResult, _IsEntirety));
        }
        #endregion

        #region �Ƿ�EMail���ͣ�XXX@XXX.XXX \w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*��
        /**//// <summary>
        /// �Ƿ�EMail���ͣ�XXX@XXX.XXX \w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsEmail()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ�Internet URL��ַ���ͣ�http://��
        /**//// <summary>
        /// �Ƿ�Internet URL��ַ���ͣ�http://��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsURL()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ������ַ���[\u4e00-\u9fa5]��
        /**//// <summary>
        /// �Ƿ������ַ���[\u4e00-\u9fa5]��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsChineseWord()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[\u4e00-\u9fa5]", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ������֣�0��9������[\d]+��������������"."��"-"
        /**//// <summary>
        /// �Ƿ������֣�0��9������[\d]+��������������"."��"-"
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsNumber()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[\d]+", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ�ֻ�������֣�Ӣ�ĺ��»��ߣ�[\w]+��
        /**//// <summary>
        /// �Ƿ�ֻ�������֣�Ӣ�ĺ��»��ߣ�[\w]+��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsStringModel_01()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[\w]+", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ��д����ĸ��Ӣ����ĸ��[A-Z][a-z]+��
        /**//// <summary>
        /// �Ƿ��д����ĸ��Ӣ����ĸ��[A-Z][a-z]+��
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsStringModel_02()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[A-Z][a-z]+", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ�ȫ���ַ���[^\x00-\xff]����������������
        /**//// <summary>
        /// �Ƿ�ȫ���ַ���[^\x00-\xff]����������������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsWideWord()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[^\x00-\xff]", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ����ַ���[\x00-\xff]��
        /**//// <summary>
        /// �Ƿ����ַ���[^\x00-\xff]����������������
        /// </summary>
        /// <returns>Boolean</returns>
        protected bool IsNarrowWord()
        {
            ArrayList aryResult = new ArrayList();
            return CommRegularMatch(_String, @"[\x00-\xff]", RegexOptions.None, ref aryResult, _IsEntirety);
        }
        #endregion

        #region �Ƿ�Ϸ����й����֤����
        protected bool IsChineseID()
        {
            if (_String.Length == 15)
            {
                _String = CidUpdate(_String);
            }
            if (_String.Length == 18)
            {
                string strResult = CheckCidInfo(_String);
                if (strResult == "�Ƿ�����" || strResult == "�Ƿ�����" || strResult == "�Ƿ�֤��")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #endregion

        #region ͨ��������ʽ�жϺ���
        /**//// <summary>
        /// ͨ��������ʽ�жϺ���
        /// </summary>
        /// <param name="strVerifyString">String������ƥ����ַ���</param>
        /// <param name="strRegular">String��������ʽ</param>
        /// <param name="regOption">RegexOptions������������ʽ��ѡ��</param>
        /// <param name="aryResult">ArrayList���ֽ���ַ�������</param>
        /// <param name="IsEntirety">Boolean���Ƿ���Ҫ��ȫƥ��</param>
        /// <returns></returns>
        public bool CommRegularMatch(string strVerifyString, string strRegular, System.Text.RegularExpressions.RegexOptions regOption, ref System.Collections.ArrayList aryResult, bool IsEntirety)
        {
            System.Text.RegularExpressions.Regex r;
            System.Text.RegularExpressions.Match m;

            #region �����Ҫ��ȫƥ��Ĵ���
            if (IsEntirety)
            {
                strRegular = strRegular.Insert(0, @"\A");
                strRegular = strRegular.Insert(strRegular.Length, @"\z");
            }
            #endregion

            try
            {
                r = new System.Text.RegularExpressions.Regex(strRegular, regOption);
            }
            catch (System.Exception e)
            {
                throw (e);
            }

            for (m = r.Match(strVerifyString); m.Success; m = m.NextMatch())
            {
                aryResult.Add(m);
            }

            if (aryResult.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region �й����֤������֤
        private string CheckCidInfo(string cid)
        {
            string[] aCity = new string[] { null, null, null, null, null, null, null, null, null, null, null, "����", "���", "�ӱ�", "ɽ��", "���ɹ�", null, null, null, null, null, "����", "����", "������", null, null, null, null, null, null, null, "�Ϻ�", "����", "�㽭", "��΢", "����", "����", "ɽ��", null, null, null, "����", "����", "����", "�㶫", "����", "����", null, null, null, "����", "�Ĵ�", "����", "����", "����", null, null, null, null, null, null, "����", "����", "�ຣ", "����", "�½�", null, null, null, null, null, "̨��", null, null, null, null, null, null, null, null, null, "���", "����", null, null, null, null, null, null, null, null, "����" };
            double iSum = 0;
            string info = string.Empty;
            System.Text.RegularExpressions.Regex rg = new System.Text.RegularExpressions.Regex(@"^\d{17}(\d|x)$");
            System.Text.RegularExpressions.Match mc = rg.Match(cid);
            if (!mc.Success)
            {
                return string.Empty;
            }
            cid = cid.ToLower();
            cid = cid.Replace("x", "a");
            if (aCity[int.Parse(cid.Substring(0, 2))] == null)
            {
                return "�Ƿ�����";
            }
            try
            {
                DateTime.Parse(cid.Substring(6, 4) + " - " + cid.Substring(10, 2) + " - " + cid.Substring(12, 2));
            }
            catch
            {
                return "�Ƿ�����";
            }
            for (int i = 17; i >= 0; i--)
            {
                iSum += (System.Math.Pow(2, i) % 11) * int.Parse(cid[17 - i].ToString(), System.Globalization.NumberStyles.HexNumber);
            }
            if (iSum % 11 != 1)
            {
                return ("�Ƿ�֤��");
            }
            else
            {
                return (aCity[int.Parse(cid.Substring(0, 2))] + "," + cid.Substring(6, 4) + "-" + cid.Substring(10, 2) + "-" + cid.Substring(12, 2) + "," + (int.Parse(cid.Substring(16, 1)) % 2 == 1 ? "��" : "Ů"));
            }
        }
        #endregion

        #region ���֤����15����Ϊ18λ
        public string CidUpdate(string ShortCid)
        {
            char[] strJiaoYan = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
            int[] intQuan = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2, 1 };
            string strTemp;
            int intTemp = 0;

            strTemp = ShortCid.Substring(0, 6) + "19" + ShortCid.Substring(6);
            for (int i = 0; i <= strTemp.Length - 1; i++)
            {
                intTemp += int.Parse(strTemp.Substring(i, 1)) * intQuan[i];
            }
            intTemp = intTemp % 11;
            return strTemp + strJiaoYan[intTemp];
        }
        #endregion

	}
}
