using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�Ѫ��������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:15
    /// </summary>
    [Serializable]
    public class T_CBC
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
        private T_CBC()
        {
        }

        public static readonly T_CBC Empty = new T_CBC();

        public static readonly T_CBC a = new T_CBC()
        {
            id = 1,
            name = "Ѫ�쵰��"
        };

        public static readonly T_CBC b = new T_CBC()
        {
            id = 2,
            name = "��ϸ��"
        };

        public static readonly T_CBC c = new T_CBC()
        {
            id = 3,
            name = "ѪС��"
        };

        public static readonly T_CBC d = new T_CBC()
        {
            id = 4,
            name = "����"
        };

        /// <summary>���С�Ѫ���桱�����б�</summary>
        public static readonly List<T_CBC> AllList = new List<T_CBC>
        {
            T_CBC.a,
            T_CBC.b,
            T_CBC.c,
            T_CBC.d
        };

        /// <summary>���ݡ�Ѫ���桱��ţ�����һ����Ѫ���桱����</summary>
        public static T_CBC GetDataById(int id)
        {
            foreach (T_CBC tmpT_CBC in AllList)
            {
                if (tmpT_CBC.Id == id)
                    return tmpT_CBC;
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
