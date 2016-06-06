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
    /// �������ƣ�Ѫѹ�����ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵����Ѫѹ���ʵ����,���ڼ�¼���ն˻�ȡ����xml�������.
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:56:45
    /// </summary>
    public class PressureBLL
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
        internal static DAL.Common.PressureDAL DataAccess
        {
            get
            {
                return DAL.Common.PressureDAL.Instance;
            }
        }


        /// <summary>
        /// ��Ѫѹ����ࣨPressure��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public static void CheckValid(Pressure pressure)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(pressure.Checkdate))
                throw new CustomException("��������ڡ�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(pressure.ExamNo))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(pressure.CheckID))
                throw new CustomException("�����š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(pressure.Name))
                throw new CustomException("������������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(pressure.Check_flag))
                throw new CustomException("������־������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(pressure.Status))
                throw new CustomException("��״̬������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(pressure.ExamNo , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.CheckID , 50))
                throw new CustomException("�����š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Name , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Sex.ToString() , 50))
                throw new CustomException("���Ա𡱳��Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Doctor , 50))
                throw new CustomException("������ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.DeviceID , 50))
                throw new CustomException("���豸�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Version , 50))
                throw new CustomException("���汾�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Reserve , 50))
                throw new CustomException("�������ֶΡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Hosname , 50))
                throw new CustomException("��ҽԺ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Auditdoctor , 50))
                throw new CustomException("�����ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str1 , 50))
                throw new CustomException("����Ա���͡����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str2 , 50))
                throw new CustomException("��Ѫѹ��λ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str3 , 50))
                throw new CustomException("�����֤�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str4 , 50))
                throw new CustomException("��Ѫѹ���𡱳��Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str5 , 50))
                throw new CustomException("�����۽��顱���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str6 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str7 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str8 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str9 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.Str10 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001002_ename , 50))
                throw new CustomException("������ѹ��ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001002_cname , 50))
                throw new CustomException("������ѹȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001002_unit , 50))
                throw new CustomException("������ѹUNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001003_ename , 50))
                throw new CustomException("������ѹ��ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001003_cname , 50))
                throw new CustomException("������ѹȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001003_unit , 50))
                throw new CustomException("������ѹUNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001004_ename , 50))
                throw new CustomException("��ƽ��ѹ��ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001004_cname , 50))
                throw new CustomException("��ƽ��ѹȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001004_unit , 50))
                throw new CustomException("��ƽ��ѹUNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001008_ename , 50))
                throw new CustomException("�����ʼ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001008_cname , 50))
                throw new CustomException("������ȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(pressure.T3001008_unit , 50))
                throw new CustomException("������UNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public static int Insert(Pressure pressure)
        {
            CheckValid(pressure);
            return DataAccess.Insert(pressure);
        }


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public static int Update(Pressure pressure)
        {
            CheckValid(pressure);
            return DataAccess.Update(pressure);
        }


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id���������ݿ��л�ȡѪѹ����ࣨPressure����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫѹ����ࣨPressure����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public static Pressure GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id���������ݿ��л�ȡѪѹ����ࣨPressure����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫѹ����ࣨPressure����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public static Pressure GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫѹ����ࣨPressure��List�б�
        /// </summary>
        public static List<Pressure> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫѹ����ࣨPressure�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫѹ����ࣨPressure���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
