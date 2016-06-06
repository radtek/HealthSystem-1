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
    /// �������ƣ����¼����ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵�������¼��ʵ����,���ڼ�¼�ն˲ɼ�����������������.
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:57:39
    /// </summary>
    public class TemperatureBLL
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
        internal static DAL.Common.TemperatureDAL DataAccess
        {
            get
            {
                return DAL.Common.TemperatureDAL.Instance;
            }
        }


        /// <summary>
        /// �����¼���ࣨTemperature��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        public static void CheckValid(Temperature temperature)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(temperature.Checkdate))
                throw new CustomException("��������ڡ�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(temperature.ExamNo))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(temperature.CheckID))
                throw new CustomException("�����š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(temperature.Name))
                throw new CustomException("������������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(temperature.Check_flag))
                throw new CustomException("������־������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(temperature.Status))
                throw new CustomException("��״̬������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(temperature.ExamNo , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.CheckID , 50))
                throw new CustomException("�����š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Name , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Sex.ToString() , 50))
                throw new CustomException("���Ա𡱳��Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Doctor , 50))
                throw new CustomException("������ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.DeviceID , 50))
                throw new CustomException("���豸�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Version , 50))
                throw new CustomException("���汾�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Reserve , 50))
                throw new CustomException("�������ֶΡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Hosname , 50))
                throw new CustomException("��ҽԺ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Auditdoctor , 50))
                throw new CustomException("�����ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str1 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str2 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str3 , 50))
                throw new CustomException("�����֤�š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str4 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str5 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str6 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str7 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str8 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str9 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.Str10 , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.T3001007_ename , 50))
                throw new CustomException("�����¼�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.T3001007_cname , 50))
                throw new CustomException("������ȫ�ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(temperature.T3001007_unit , 50))
                throw new CustomException("������UNIT�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// �����¼���ࣨTemperature�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        public static int Insert(Temperature temperature)
        {
            CheckValid(temperature);
            return DataAccess.Insert(temperature);
        }


        /// <summary>
        /// �����¼���ࣨTemperature�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        public static int Update(Temperature temperature)
        {
            CheckValid(temperature);
            return DataAccess.Update(temperature);
        }


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id���������ݿ��л�ȡ���¼���ࣨTemperature����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼���������¼���ࣨTemperature����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public static Temperature GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id���������ݿ��л�ȡ���¼���ࣨTemperature����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼���������¼���ࣨTemperature����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public static Temperature GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ�������������¼���ࣨTemperature��List�б�
        /// </summary>
        public static List<Temperature> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ������¼���ࣨTemperature�����б���ҳ��Ϣ��
        /// �÷�������ȡ�����¼���ࣨTemperature���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
