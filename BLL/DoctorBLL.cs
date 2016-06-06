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
    /// �������ƣ�����ҽ��ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵��������ҽ��ʵ����
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016/4/28 13:59:21
    /// </summary>
    public class DoctorBLL
    {
        #region ������µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ��������Զ����ɣ���Ҫ�ṩ����Ļ���ҵ���߼����벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö�����������ɸ������еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// �����뱾������������ݷ����ࡣͨ��������Ҫ����������������ݷ����࣬�����ݿ���н���ʱ��Ӧ����ʹ�ø����ԣ�
        /// �������ҵ���߼�������ҵ���߼���ʱ��Ӧ������ʹ���������й����ķ�������������ʹ���������е�DataAccess���ԡ�
        /// </summary>
        internal static DAL.Common.DoctorDAL DataAccess
        {
            get
            {
                return DAL.Common.DoctorDAL.Instance;
            }
        }


        /// <summary>
        /// ������ҽ����Doctor��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public static void CheckValid(Doctor doctor)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(doctor.Name))
                throw new CustomException("������������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(doctor.DoctorId , 50))
                throw new CustomException("��ҽ����š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(doctor.Name , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(doctor.ExamNo , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(doctor.Pwd , 50))
                throw new CustomException("�����롱���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(doctor.Remarks , 50))
                throw new CustomException("����ע�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ������ҽ����Doctor�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public static int Insert(Doctor doctor)
        {
            CheckValid(doctor);
            return DataAccess.Insert(doctor);
        }


        /// <summary>
        /// ������ҽ����Doctor�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public static int Update(Doctor doctor)
        {
            CheckValid(doctor);
            return DataAccess.Update(doctor);
        }


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public static Doctor GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public static Doctor GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }



        /// <summary>
        /// ��������ҽ����Doctor���ġ�ҽ����ţ�DoctorId���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����ҽ����Doctor���ġ�ҽ����ţ�DoctorId����</param>
        public static Doctor GetDataByDoctorId(string doctorid)
        {
            return DataAccess.GetDataByDoctorId(doctorid);
        }

        /// <summary>
        /// �����ݿ��ж�ȡ��������������ҽ����Doctor��List�б�
        /// </summary>
        public static List<Doctor> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ�������ҽ����Doctor�����б���ҳ��Ϣ��
        /// �÷�������ȡ������ҽ����Doctor���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


        #endregion ������µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ��ҵ���߼���Ĺ��ܣ�������ı��������Լ����ҵ���߼���������  
        //  ע�⣺�û������Ӧ��ֻ����ñ�����������в���������Թ��������ݷ�������ã�Ӧ��ֻͨ�����е�DataAccess����ʵ�֡�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
