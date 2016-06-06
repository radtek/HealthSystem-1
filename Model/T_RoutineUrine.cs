using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ��򳣹�����ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:23
    /// </summary>
    [Serializable]
    public class T_RoutineUrine
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
        private T_RoutineUrine()
        {
        }

        public static readonly T_RoutineUrine Empty = new T_RoutineUrine();

        public static readonly T_RoutineUrine a = new T_RoutineUrine()
        {
            id = 1,
            name = "�򵰰�"
        };

        public static readonly T_RoutineUrine b = new T_RoutineUrine()
        {
            id = 2,
            name = "����"
        };

        public static readonly T_RoutineUrine c = new T_RoutineUrine()
        {
            id = 3,
            name = "��ͪ��"
        };

        public static readonly T_RoutineUrine d = new T_RoutineUrine()
        {
            id = 4,
            name = "��ǱѪ"
        };

        public static readonly T_RoutineUrine e = new T_RoutineUrine()
        {
            id = 5,
            name = "����"
        };

        /// <summary>���С��򳣹桱�����б�</summary>
        public static readonly List<T_RoutineUrine> AllList = new List<T_RoutineUrine>
        {
            T_RoutineUrine.a,
            T_RoutineUrine.b,
            T_RoutineUrine.c,
            T_RoutineUrine.d,
            T_RoutineUrine.e
        };

        /// <summary>���ݡ��򳣹桱��ţ�����һ�����򳣹桱����</summary>
        public static T_RoutineUrine GetDataById(int id)
        {
            foreach (T_RoutineUrine tmpT_RoutineUrine in AllList)
            {
                if (tmpT_RoutineUrine.Id == id)
                    return tmpT_RoutineUrine;
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
