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
    /// ��д���ڣ�2016-4-21 17:10:12
    /// </summary>
    [Serializable]
    public class T_KidneyDisease
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
        private T_KidneyDisease()
        {
        }

        public static readonly T_KidneyDisease Empty = new T_KidneyDisease();

        public static readonly T_KidneyDisease a = new T_KidneyDisease()
        {
            id = 0,
            name = "δ����"
        };

        public static readonly T_KidneyDisease b = new T_KidneyDisease()
        {
            id = 1,
            name = "��������"
        };

        public static readonly T_KidneyDisease c = new T_KidneyDisease()
        {
            id = 2,
            name = "������˥��"
        };

        public static readonly T_KidneyDisease d = new T_KidneyDisease()
        {
            id = 3,
            name = "��������"
        };

        public static readonly T_KidneyDisease e = new T_KidneyDisease()
        {
            id = 4,
            name = "��������"
        };

        public static readonly T_KidneyDisease f = new T_KidneyDisease()
        {
            id = 5,
            name = "����"
        };

        /// <summary>���С����༲���������б�</summary>
        public static readonly List<T_KidneyDisease> AllList = new List<T_KidneyDisease>
        {
            T_KidneyDisease.a,
            T_KidneyDisease.b,
            T_KidneyDisease.c,
            T_KidneyDisease.d,
            T_KidneyDisease.e,
            T_KidneyDisease.f
        };

        /// <summary>���ݡ����༲������ţ�����һ�������༲��������</summary>
        public static T_KidneyDisease GetDataById(int id)
        {
            foreach (T_KidneyDisease tmpT_KidneyDisease in AllList)
            {
                if (tmpT_KidneyDisease.Id == id)
                    return tmpT_KidneyDisease;
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
