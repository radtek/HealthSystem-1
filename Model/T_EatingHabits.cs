using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���ʳϰ������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:07
    /// </summary>
    [Serializable]
    public class T_EatingHabits
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
        private T_EatingHabits()
        {
        }

        public static readonly T_EatingHabits Empty = new T_EatingHabits();

        public static readonly T_EatingHabits a = new T_EatingHabits()
        {
            id = 1,
            name = "���ؾ���"
        };

        public static readonly T_EatingHabits b = new T_EatingHabits()
        {
            id = 2,
            name = "��ʳΪ��"
        };

        public static readonly T_EatingHabits c = new T_EatingHabits()
        {
            id = 3,
            name = "��ʳΪ��"
        };

        public static readonly T_EatingHabits d = new T_EatingHabits()
        {
            id = 4,
            name = "����"
        };

        public static readonly T_EatingHabits e = new T_EatingHabits()
        {
            id = 5,
            name = "����"
        };

        public static readonly T_EatingHabits f = new T_EatingHabits()
        {
            id = 6,
            name = "����"
        };

        /// <summary>���С���ʳϰ�ߡ������б�</summary>
        public static readonly List<T_EatingHabits> AllList = new List<T_EatingHabits>
        {
            T_EatingHabits.a,
            T_EatingHabits.b,
            T_EatingHabits.c,
            T_EatingHabits.d,
            T_EatingHabits.e,
            T_EatingHabits.f
        };

        /// <summary>���ݡ���ʳϰ�ߡ���ţ�����һ������ʳϰ�ߡ�����</summary>
        public static T_EatingHabits GetDataById(int id)
        {
            foreach (T_EatingHabits tmpT_EatingHabits in AllList)
            {
                if (tmpT_EatingHabits.Id == id)
                    return tmpT_EatingHabits;
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
