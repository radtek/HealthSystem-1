using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�Ѫ֬����ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:49
    /// </summary>
    [Serializable]
    public class T_TG
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
        private T_TG()
        {
        }

        public static readonly T_TG Empty = new T_TG();

        public static readonly T_TG a = new T_TG()
        {
            id = 1,
            name = "�ܵ��̴�"
        };

        public static readonly T_TG b = new T_TG()
        {
            id = 2,
            name = "��������"
        };

        public static readonly T_TG c = new T_TG()
        {
            id = 3,
            name = "Ѫ����ܶ�֬���׵��̴�"
        };

        public static readonly T_TG d = new T_TG()
        {
            id = 4,
            name = "Ѫ����ܶ�֬���׵��̴�"
        };

        /// <summary>���С�Ѫ֬�������б�</summary>
        public static readonly List<T_TG> AllList = new List<T_TG>
        {
            T_TG.a,
            T_TG.b,
            T_TG.c,
            T_TG.d
        };

        /// <summary>���ݡ�Ѫ֬����ţ�����һ����Ѫ֬������</summary>
        public static T_TG GetDataById(int id)
        {
            foreach (T_TG tmpT_TG in AllList)
            {
                if (tmpT_TG.Id == id)
                    return tmpT_TG;
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
