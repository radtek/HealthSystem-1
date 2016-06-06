using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:57
    /// </summary>
    [Serializable]
    public class T_Physical
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
        private T_Physical()
        {
        }

        public static readonly T_Physical Empty = new T_Physical();

        public static readonly T_Physical a = new T_Physical()
        {
            id = 1,
            name = "������"
        };

        public static readonly T_Physical b = new T_Physical()
        {
            id = 2,
            name = "������"
        };

        public static readonly T_Physical c = new T_Physical()
        {
            id = 3,
            name = "������"
        };

        public static readonly T_Physical d = new T_Physical()
        {
            id = 4,
            name = "̵ʪ��"
        };

        public static readonly T_Physical e = new T_Physical()
        {
            id = 5,
            name = "ʪ����"
        };

        public static readonly T_Physical f = new T_Physical()
        {
            id = 6,
            name = "Ѫ����"
        };

        public static readonly T_Physical g = new T_Physical()
        {
            id = 7,
            name = "������"
        };

        public static readonly T_Physical h = new T_Physical()
        {
            id = 8,
            name = "ƽ����"
        };

        /// <summary>���С����ʡ������б�</summary>
        public static readonly List<T_Physical> AllList = new List<T_Physical>
        {
            T_Physical.a,
            T_Physical.b,
            T_Physical.c,
            T_Physical.d,
            T_Physical.e,
            T_Physical.f,
            T_Physical.g,
            T_Physical.h
        };

        /// <summary>���ݡ����ʡ���ţ�����һ�������ʡ�����</summary>
        public static T_Physical GetDataById(int id)
        {
            foreach (T_Physical tmpT_Physical in AllList)
            {
                if (tmpT_Physical.Id == id)
                    return tmpT_Physical;
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
