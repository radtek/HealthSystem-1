using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�����������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:09:41
    /// </summary>
    [Serializable]
    public class T_Renal
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
        private T_Renal()
        {
        }

        public static readonly T_Renal Empty = new T_Renal();

        public static readonly T_Renal a = new T_Renal()
        {
            id = 1,
            name = "Ѫ�弡��"
        };

        public static readonly T_Renal b = new T_Renal()
        {
            id = 2,
            name = "Ѫ���ص�"
        };

        public static readonly T_Renal c = new T_Renal()
        {
            id = 3,
            name = "Ѫ��Ũ��"
        };

        public static readonly T_Renal d = new T_Renal()
        {
            id = 4,
            name = "Ѫ��Ũ��"
        };

        /// <summary>���С������ܡ������б�</summary>
        public static readonly List<T_Renal> AllList = new List<T_Renal>
        {
            T_Renal.a,
            T_Renal.b,
            T_Renal.c,
            T_Renal.d
        };

        /// <summary>���ݡ������ܡ���ţ�����һ���������ܡ�����</summary>
        public static T_Renal GetDataById(int id)
        {
            foreach (T_Renal tmpT_Renal in AllList)
            {
                if (tmpT_Renal.Id == id)
                    return tmpT_Renal;
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
