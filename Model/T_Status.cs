using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���ӡ״̬����ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:49
    /// </summary>
    [Serializable]
    public class T_Status
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
        private T_Status()
        {
        }

        public static readonly T_Status Empty = new T_Status();

        public static readonly T_Status Not = new T_Status()
        {
            id = 0,
            name = "����ӡ"
        };

        public static readonly T_Status Print  = new T_Status()
        {
            id = 1,
            name = "��ӡ"
        };

        public static readonly T_Status Other = new T_Status()
        {
            id = 2,
            name = "����ֵ����չ"
        };

        /// <summary>���С���ӡ״̬�������б�</summary>
        public static readonly List<T_Status> AllList = new List<T_Status>
        {
            T_Status.Not,
            T_Status.Print ,
            T_Status.Other
        };

        /// <summary>���ݡ���ӡ״̬����ţ�����һ������ӡ״̬������</summary>
        public static T_Status GetDataById(int id)
        {
            foreach (T_Status tmpT_Status in AllList)
            {
                if (tmpT_Status.Id == id)
                    return tmpT_Status;
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
