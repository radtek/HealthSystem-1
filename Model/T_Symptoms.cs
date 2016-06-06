using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�֢״����ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:08:57
    /// </summary>
    [Serializable]
    public class T_Symptoms
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
        private T_Symptoms()
        {
        }

        public static readonly T_Symptoms Empty = new T_Symptoms();

        public static readonly T_Symptoms a = new T_Symptoms()
        {
            id = 0,
            name = "��"
        };

        public static readonly T_Symptoms b = new T_Symptoms()
        {
            id = 1,
            name = "ͷʹ"
        };

        public static readonly T_Symptoms c = new T_Symptoms()
        {
            id = 2,
            name = "ͷ��"
        };

        public static readonly T_Symptoms d = new T_Symptoms()
        {
            id = 3,
            name = "�ļ�"
        };

        public static readonly T_Symptoms e = new T_Symptoms()
        {
            id = 4,
            name = "����"
        };

        public static readonly T_Symptoms f = new T_Symptoms()
        {
            id = 5,
            name = "��ʹ"
        };

        public static readonly T_Symptoms g = new T_Symptoms()
        {
            id = 6,
            name = "���Կ���"
        };

        public static readonly T_Symptoms h = new T_Symptoms()
        {
            id = 7,
            name = "��̵"
        };

        public static readonly T_Symptoms i = new T_Symptoms()
        {
            id = 8,
            name = "��������"
        };

        public static readonly T_Symptoms j = new T_Symptoms()
        {
            id = 9,
            name = "����"
        };

        public static readonly T_Symptoms k = new T_Symptoms()
        {
            id = 10,
            name = "����"
        };

        public static readonly T_Symptoms l = new T_Symptoms()
        {
            id = 11,
            name = "�����½�"
        };

        public static readonly T_Symptoms m = new T_Symptoms()
        {
            id = 12,
            name = "����"
        };

        public static readonly T_Symptoms n = new T_Symptoms()
        {
            id = 13,
            name = "�ؽ���ʹ"
        };

        public static readonly T_Symptoms o = new T_Symptoms()
        {
            id = 14,
            name = "����ģ��"
        };

        public static readonly T_Symptoms p = new T_Symptoms()
        {
            id = 15,
            name = "�ֽ���ľ"
        };

        public static readonly T_Symptoms q = new T_Symptoms()
        {
            id = 16,
            name = "��"
        };

        public static readonly T_Symptoms r = new T_Symptoms()
        {
            id = 17,
            name = "��ʹ"
        };

        public static readonly T_Symptoms x = new T_Symptoms()
        {
            id = 18,
            name = "����"
        };

        public static readonly T_Symptoms t = new T_Symptoms()
        {
            id = 19,
            name = "��к"
        };

        public static readonly T_Symptoms u = new T_Symptoms()
        {
            id = 20,
            name = "����Ż��"
        };

        public static readonly T_Symptoms v = new T_Symptoms()
        {
            id = 21,
            name = "�ۻ�"
        };

        public static readonly T_Symptoms w = new T_Symptoms()
        {
            id = 22,
            name = "����"
        };

        public static readonly T_Symptoms y = new T_Symptoms()
        {
            id = 23,
            name = "�鷿��ʹ"
        };

        public static readonly T_Symptoms z = new T_Symptoms()
        {
            id = 24,
            name = "����"
        };

        /// <summary>���С�֢״�������б�</summary>
        public static readonly List<T_Symptoms> AllList = new List<T_Symptoms>
        {
            T_Symptoms.a,
            T_Symptoms.b,
            T_Symptoms.c,
            T_Symptoms.d,
            T_Symptoms.e,
            T_Symptoms.f,
            T_Symptoms.g,
            T_Symptoms.h,
            T_Symptoms.i,
            T_Symptoms.j,
            T_Symptoms.k,
            T_Symptoms.l,
            T_Symptoms.m,
            T_Symptoms.n,
            T_Symptoms.o,
            T_Symptoms.p,
            T_Symptoms.q,
            T_Symptoms.r,
            T_Symptoms.x,
            T_Symptoms.t,
            T_Symptoms.u,
            T_Symptoms.v,
            T_Symptoms.w,
            T_Symptoms.y,
            T_Symptoms.z
        };

        /// <summary>���ݡ�֢״����ţ�����һ����֢״������</summary>
        public static T_Symptoms GetDataById(int id)
        {
            foreach (T_Symptoms tmpT_Symptoms in AllList)
            {
                if (tmpT_Symptoms.Id == id)
                    return tmpT_Symptoms;
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
