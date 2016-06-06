using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ��ι�������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:32
    /// </summary>
    [Serializable]
    public class T_Liver
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]���</summary>
        private int? id;
        /// <summary>[����]����</summary>
        private string name;


        /// <summary>[����]���</summary>
        public int? Id
        {
            get { return id; }
        }
        /// <summary>[����]����</summary>
        public string Name
        {
            get { return name; }
        }


        /// <summary>ʵ�������󷽷���˽�н����ڲ�����</summary>
        private T_Liver()
        {
        }

        public static readonly T_Liver Empty = new T_Liver();

        public static readonly T_Liver a = new T_Liver()
        {
            id = 1,
            name = "Ѫ���ת��ø"
        };

        public static readonly T_Liver b = new T_Liver()
        {
            id = 2,
            name = "Ѫ��Ȳ�ת��ø"
        };

        public static readonly T_Liver c = new T_Liver()
        {
            id = 3,
            name = "�׵���"
        };

        public static readonly T_Liver d = new T_Liver()
        {
            id = 4,
            name = "�ܵ�����"
        };

        public static readonly T_Liver e = new T_Liver()
        {
            id = 5,
            name = "��ϵ�����"
        };

        /// <summary>���С��ι��ܡ������б�</summary>
        public static readonly List<T_Liver> AllList = new List<T_Liver>
        {
            T_Liver.a,
            T_Liver.b,
            T_Liver.c,
            T_Liver.d,
            T_Liver.e
        };

        /// <summary>���ݡ��ι��ܡ���ţ�����һ�����ι��ܡ�����</summary>
        public static T_Liver GetDataById(int id)
        {
            foreach (T_Liver tmpT_Liver in AllList)
            {
                if (tmpT_Liver.Id == id)
                    return tmpT_Liver;
            }
            return null;
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
