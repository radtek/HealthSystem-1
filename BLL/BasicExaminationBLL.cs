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
    /// �������ƣ���������ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵��������һ������������¼�����Ե������Ϣ
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:59
    /// </summary>
    public class BasicExaminationBLL
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
        internal static DAL.Common.BasicExaminationDAL DataAccess
        {
            get
            {
                return DAL.Common.BasicExaminationDAL.Instance;
            }
        }


        /// <summary>
        /// �Ի�������BasicExamination��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public static void CheckValid(BasicExamination basicExamination)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(basicExamination.Id))
                throw new CustomException("����š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(basicExamination.ResidentId))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            if (DataValid.IsNull(basicExamination.CheckID))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(basicExamination.ResidentId , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.TheName , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.CheckID , 50))
                throw new CustomException("������š����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.CheckDate , 50))
                throw new CustomException("��������ڡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.Doctor , 50))
                throw new CustomException("�����ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.PhysicalExercise , 50))
                throw new CustomException("���������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.Smoking , 50))
                throw new CustomException("��������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.Drinking , 50))
                throw new CustomException("��������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(basicExamination.OccupationalExposure , 50))
                throw new CustomException("��ְҵ��¶��������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ����������BasicExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public static int Insert(BasicExamination basicExamination)
        {
            CheckValid(basicExamination);
            return DataAccess.Insert(basicExamination);
        }


        /// <summary>
        /// ����������BasicExamination�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public static int Update(BasicExamination basicExamination)
        {
            CheckValid(basicExamination);
            return DataAccess.Update(basicExamination);
        }


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id���������ݿ��л�ȡ��������BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»�������BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public static BasicExamination GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id���������ݿ��л�ȡ��������BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»�������BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public static BasicExamination GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������л�������BasicExamination��List�б�
        /// </summary>
        public static List<BasicExamination> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��Ļ�������BasicExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�Ļ�������BasicExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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


        /// <summary>
        /// ���ݻ����������ƣ�BasicExamination�����ֶΡ�TheName��TheName���������ݿ��л�ȡ�����������ƣ�BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»����������ƣ�BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="theName">�����������ƣ�BasicExamination�����ֶΡ�TheName��TheName����</param>
        public static List<BasicExamination> GetDataByTheName(string theName)
        {
            return DataAccess.GetDataByTheName(theName);
        }







    }
}
