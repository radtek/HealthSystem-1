using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�Ѫ�ܼ�������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:10:27
    /// </summary>
    [Serializable]
    public class T_VascularDisease
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
        private T_VascularDisease()
        {
        }

        public static readonly T_VascularDisease Empty = new T_VascularDisease();

        public static readonly T_VascularDisease a = new T_VascularDisease()
        {
            id = 0,
            name = "δ����"
        };

        public static readonly T_VascularDisease b = new T_VascularDisease()
        {
            id = 1,
            name = "�в㶯����"
        };

        public static readonly T_VascularDisease c = new T_VascularDisease()
        {
            id = 2,
            name = "���������Լ���"
        };

        public static readonly T_VascularDisease d = new T_VascularDisease()
        {
            id = 3,
            name = "����"
        };

        /// <summary>���С�Ѫ�ܼ����������б�</summary>
        public static readonly List<T_VascularDisease> AllList = new List<T_VascularDisease>
        {
            T_VascularDisease.a,
            T_VascularDisease.b,
            T_VascularDisease.c,
            T_VascularDisease.d
        };

        /// <summary>���ݡ�Ѫ�ܼ�������ţ�����һ����Ѫ�ܼ���������</summary>
        public static T_VascularDisease GetDataById(int id)
        {
            foreach (T_VascularDisease tmpT_VascularDisease in AllList)
            {
                if (tmpT_VascularDisease.Id == id)
                    return tmpT_VascularDisease;
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
