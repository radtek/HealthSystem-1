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
    /// �������ƣ�����ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵���������еĻ�����Ա��ɣ���ϵͳ������������֮һ��
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:41:14
    /// </summary>
    public class ResidentBLL
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
        internal static DAL.Common.ResidentDAL DataAccess
        {
            get
            {
                return DAL.Common.ResidentDAL.Instance;
            }
        }


        /// <summary>
        /// �Ծ���Resident��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public static void CheckValid(Resident resident)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(resident.ResidentId))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(resident.Name))
                throw new CustomException("������������Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(resident.IdNumber))
                throw new CustomException("�����֤�š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(resident.ResidentId , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Name , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Phone , 20))
                throw new CustomException("����ϵ�绰�����Ȳ��ܳ��� 20 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Nation , 20))
                throw new CustomException("�����塱���Ȳ��ܳ��� 20 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.ContactName , 50))
                throw new CustomException("����ϵ�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.ContactPhone , 20))
                throw new CustomException("����ϵ�˵绰�����Ȳ��ܳ��� 20 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Professional , 50))
                throw new CustomException("��ְҵ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.WorkUnits , 50))
                throw new CustomException("��������λ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.FathersName , 50))
                throw new CustomException("���������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.MotherName , 50))
                throw new CustomException("��ĸ�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.GuardiansName , 50))
                throw new CustomException("���໤�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.GuardianPhone , 50))
                throw new CustomException("���໤�˵绰�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Registered , 50))
                throw new CustomException("���������ڵء����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.RegisteredAddress , 50))
                throw new CustomException("��������ַ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Live , 50))
                throw new CustomException("���־�ס���ڵء����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.LiveAddress , 50))
                throw new CustomException("���־�ס��ַ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.InputtingPerson , 50))
                throw new CustomException("�������ˡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.ResponsibleDoctor , 50))
                throw new CustomException("������ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(resident.Remarks , 200))
                throw new CustomException("����ע�����Ȳ��ܳ��� 200 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ������Resident�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public static int Insert(Resident resident)
        {
            CheckValid(resident);
            return DataAccess.Insert(resident);
        }


        /// <summary>
        /// ������Resident�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public static int Update(Resident resident)
        {
            CheckValid(resident);
            return DataAccess.Update(resident);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id���������ݿ��л�ȡ����Resident����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¾���Resident����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public static Resident GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id���������ݿ��л�ȡ����Resident����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¾���Resident����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public static Resident GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������о���Resident��List�б�
        /// </summary>
        public static List<Resident> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ľ���Resident�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ľ���Resident���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
