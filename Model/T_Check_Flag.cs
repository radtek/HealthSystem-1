using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�����־����ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:36
    /// </summary>
    [Serializable]
    public class T_Check_Flag
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]���</summary>
        private int? id;
        /// <summary>[����]����</summary>
        private string value;


        /// <summary>[����]���</summary>
        public int? Id
        {
            get { return id; }
        }
        /// <summary>[����]����</summary>
        public string Value
        {
            get { return value; }
        }


        /// <summary>ʵ�������󷽷���˽�н����ڲ�����</summary>
        private T_Check_Flag()
        {
        }

        public static readonly T_Check_Flag Empty = new T_Check_Flag();

        public static readonly T_Check_Flag None = new T_Check_Flag()
        {
            id = 0,
            value = "δ���"
        };

        public static readonly T_Check_Flag Valid = new T_Check_Flag()
        {
            id = 1,
            value = "��ǰ��Ч����"
        };

        public static readonly T_Check_Flag Complete  = new T_Check_Flag()
        {
            id = 2,
            value = "����ɼ��"
        };

        public static readonly T_Check_Flag Cancel = new T_Check_Flag()
        {
            id = 3,
            value = "ע��"
        };

        /// <summary>���С�����־�������б�</summary>
        public static readonly List<T_Check_Flag> AllList = new List<T_Check_Flag>
        {
            T_Check_Flag.None,
            T_Check_Flag.Valid,
            T_Check_Flag.Complete ,
            T_Check_Flag.Cancel
        };

        /// <summary>���ݡ�����־����ţ�����һ��������־������</summary>
        public static T_Check_Flag GetDataById(int id)
        {
            foreach (T_Check_Flag tmpT_Check_Flag in AllList)
            {
                if (tmpT_Check_Flag.Id == id)
                    return tmpT_Check_Flag;
            }
            return null;
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return Value;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
