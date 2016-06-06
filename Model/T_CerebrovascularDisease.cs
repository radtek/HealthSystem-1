using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���Ѫ�ܼ�������ת���ࣨ����ʵ��㣩
    /// ����˵����������Ϊһ������ת���࣬��Ҫ�������ݴ洢Ϊ��ŵ�������Ҫ��ʾ���ֵ�ת����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:10:05
    /// </summary>
    [Serializable]
    public class T_CerebrovascularDisease
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
        private T_CerebrovascularDisease()
        {
        }

        public static readonly T_CerebrovascularDisease Empty = new T_CerebrovascularDisease();

        public static readonly T_CerebrovascularDisease a = new T_CerebrovascularDisease()
        {
            id = 0,
            name = "δ����"
        };

        public static readonly T_CerebrovascularDisease b = new T_CerebrovascularDisease()
        {
            id = 1,
            name = "ȱѪ������"
        };

        public static readonly T_CerebrovascularDisease c = new T_CerebrovascularDisease()
        {
            id = 2,
            name = "�Գ�Ѫ"
        };

        public static readonly T_CerebrovascularDisease d = new T_CerebrovascularDisease()
        {
            id = 3,
            name = "����Ĥ��ǻ��Ѫ"
        };

        public static readonly T_CerebrovascularDisease e = new T_CerebrovascularDisease()
        {
            id = 4,
            name = "��������ȱѪ����"
        };

        public static readonly T_CerebrovascularDisease f = new T_CerebrovascularDisease()
        {
            id = 5,
            name = "����"
        };

        /// <summary>���С���Ѫ�ܼ����������б�</summary>
        public static readonly List<T_CerebrovascularDisease> AllList = new List<T_CerebrovascularDisease>
        {
            T_CerebrovascularDisease.a,
            T_CerebrovascularDisease.b,
            T_CerebrovascularDisease.c,
            T_CerebrovascularDisease.d,
            T_CerebrovascularDisease.e,
            T_CerebrovascularDisease.f
        };

        /// <summary>���ݡ���Ѫ�ܼ�������ţ�����һ������Ѫ�ܼ���������</summary>
        public static T_CerebrovascularDisease GetDataById(int id)
        {
            foreach (T_CerebrovascularDisease tmpT_CerebrovascularDisease in AllList)
            {
                if (tmpT_CerebrovascularDisease.Id == id)
                    return tmpT_CerebrovascularDisease;
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
