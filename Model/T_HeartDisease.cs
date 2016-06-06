using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ����༲������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:10:20
    /// </summary>
    [Serializable]
    public class T_HeartDisease
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
        private T_HeartDisease()
        {
        }

        public static readonly T_HeartDisease Empty = new T_HeartDisease();

        public static readonly T_HeartDisease a = new T_HeartDisease()
        {
            id = 0,
            name = "δ����"
        };

        public static readonly T_HeartDisease b = new T_HeartDisease()
        {
            id = 1,
            name = "�ļ�����"
        };

        public static readonly T_HeartDisease c = new T_HeartDisease()
        {
            id = 2,
            name = "�Ľ�ʹ"
        };

        public static readonly T_HeartDisease d = new T_HeartDisease()
        {
            id = 3,
            name = "��״����Ѫ���ؽ�"
        };

        public static readonly T_HeartDisease e = new T_HeartDisease()
        {
            id = 4,
            name = "��Ѫ������˥��"
        };

        public static readonly T_HeartDisease f = new T_HeartDisease()
        {
            id = 5,
            name = "��ǰ����ʹ"
        };

        public static readonly T_HeartDisease g = new T_HeartDisease()
        {
            id = 6,
            name = "����"
        };

        /// <summary>���С����༲���������б�</summary>
        public static readonly List<T_HeartDisease> AllList = new List<T_HeartDisease>
        {
            T_HeartDisease.a,
            T_HeartDisease.b,
            T_HeartDisease.c,
            T_HeartDisease.d,
            T_HeartDisease.e,
            T_HeartDisease.f,
            T_HeartDisease.g
        };

        /// <summary>���ݡ����༲������ţ�����һ�������༲��������</summary>
        public static T_HeartDisease GetDataById(int id)
        {
            foreach (T_HeartDisease tmpT_HeartDisease in AllList)
            {
                if (tmpT_HeartDisease.Id == id)
                    return tmpT_HeartDisease;
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
