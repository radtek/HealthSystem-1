using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ��۲���������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:10:35
    /// </summary>
    [Serializable]
    public class T_EyeDisease
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
        private T_EyeDisease()
        {
        }

        public static readonly T_EyeDisease Empty = new T_EyeDisease();

        public static readonly T_EyeDisease a = new T_EyeDisease()
        {
            id = 0,
            name = "δ����"
        };

        public static readonly T_EyeDisease b = new T_EyeDisease()
        {
            id = 1,
            name = "����Ĥ��Ѫ������"
        };

        public static readonly T_EyeDisease c = new T_EyeDisease()
        {
            id = 2,
            name = "����ͷˮ��"
        };

        public static readonly T_EyeDisease d = new T_EyeDisease()
        {
            id = 3,
            name = "������"
        };

        public static readonly T_EyeDisease e = new T_EyeDisease()
        {
            id = 4,
            name = "����"
        };

        /// <summary>���С��۲������������б�</summary>
        public static readonly List<T_EyeDisease> AllList = new List<T_EyeDisease>
        {
            T_EyeDisease.a,
            T_EyeDisease.b,
            T_EyeDisease.c,
            T_EyeDisease.d,
            T_EyeDisease.e
        };

        /// <summary>���ݡ��۲���������ţ�����һ�����۲�����������</summary>
        public static T_EyeDisease GetDataById(int id)
        {
            foreach (T_EyeDisease tmpT_EyeDisease in AllList)
            {
                if (tmpT_EyeDisease.Id == id)
                    return tmpT_EyeDisease;
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
