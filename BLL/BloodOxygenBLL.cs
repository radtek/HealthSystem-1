using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.DAL;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.BLL
{
    /// <summary>
    /// �������ƣ�Ѫ�������ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵����Ѫ�������
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:55:49
    /// </summary>
    public class BloodOxygenBLL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ�ṩ����Ļ���ҵ���߼����벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// �����뱾������������ݷ����ࡣͨ��������Ҫ����������������ݷ����࣬�����ݿ���н���ʱ��Ӧ����ʹ�ø����ԣ�
        /// �������ҵ���߼�������ҵ���߼���ʱ��Ӧ������ʹ���������й����ķ�������������ʹ���������е�DataAccess���ԡ�
        /// </summary>
        internal static DAL.Common.BloodOxygenDAL DataAccess
        {
            get
            {
                return DAL.Common.BloodOxygenDAL.Instance;
            }
        }


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public static void CheckValid(BloodOxygen bloodOxygen)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(bloodOxygen.Checkdate))
                throw new CustomException("��������ڡ�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(bloodOxygen.ExamNo))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(bloodOxygen.CheckID))
                throw new CustomException("�����š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(bloodOxygen.Name))
                throw new CustomException("������������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(bloodOxygen.Check_flag))
                throw new CustomException("������ǡ�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(bloodOxygen.Status))
                throw new CustomException("��״̬������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(bloodOxygen.ExamNo , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.CheckID , 50))
                throw new CustomException("�����š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Name , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Sex.ToString() , 50))
                throw new CustomException("���Ա𡱳��Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Doctor , 50))
                throw new CustomException("������ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.DeviceID , 50))
                throw new CustomException("���豸�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Version , 50))
                throw new CustomException("���汾�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Reserve , 50))
                throw new CustomException("�������ֶΡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Hosname , 50))
                throw new CustomException("��ҽԺ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Auditdoctor , 50))
                throw new CustomException("�����ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str1 , 50))
                throw new CustomException("���ĵ���ϡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str2 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str3 , 50))
                throw new CustomException("�����֤�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str4 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str5 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str6 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str7 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str8 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str9 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.Str10 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001005_ename , 50))
                throw new CustomException("��Ѫ����ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001005_cname , 50))
                throw new CustomException("��Ѫ��ȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001005_unit , 50))
                throw new CustomException("��Ѫ��UNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001009_ename , 50))
                throw new CustomException("�����ʼ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001009_cname , 50))
                throw new CustomException("������ȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(bloodOxygen.T3001009_unit , 50))
                throw new CustomException("��UNIT(BPM)�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public static int Insert(BloodOxygen bloodOxygen)
        {
            CheckValid(bloodOxygen);
            return DataAccess.Insert(bloodOxygen);
        }


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public static int Update(BloodOxygen bloodOxygen)
        {
            CheckValid(bloodOxygen);
            return DataAccess.Update(bloodOxygen);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id���������ݿ��л�ȡѪ������ࣨBloodOxygen����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫ������ࣨBloodOxygen����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public static BloodOxygen GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id���������ݿ��л�ȡѪ������ࣨBloodOxygen����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫ������ࣨBloodOxygen����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public static BloodOxygen GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }

        public static List<BloodOxygen> GetDatasByName(string name)
        {
            return DataAccess.GetDatasByName(name);
        }

        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫ������ࣨBloodOxygen��List�б�
        /// </summary>
        public static List<BloodOxygen> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫ������ࣨBloodOxygen�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫ������ࣨBloodOxygen���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ��ҵ���߼���Ĺ��ܣ�������ı��������Լ����ҵ���߼���������  
        //  ע�⣺�û������Ӧ��ֻ����ñ�����������в���������Թ��������ݷ�������ã�Ӧ��ֻͨ�����е�DataAccess����ʵ�֡�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
