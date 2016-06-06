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
    /// �������ƣ��ִ潡�������ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵�������������ִ潡�������
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:01:17
    /// </summary>
    public class MajorProblemsBLL
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
        internal static DAL.Common.MajorProblemsDAL DataAccess
        {
            get
            {
                return DAL.Common.MajorProblemsDAL.Instance;
            }
        }


        /// <summary>
        /// ���ִ潡�������MajorProblems��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public static void CheckValid(MajorProblems majorProblems)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(majorProblems.CheckId))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(majorProblems.DiseasesOfTheNervousSystem , 50))
                throw new CustomException("����ϵͳ���������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.OtherSystemDiseases , 50))
                throw new CustomException("������ϵͳ���������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.HospitalizationIs , 50))
                throw new CustomException("��סԺ������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.MainMedications , 50))
                throw new CustomException("����Ҫ��ҩ��������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.IPVHistory , 50))
                throw new CustomException("�������߹滮Ԥ������ʷ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.HealthAssessment , 50))
                throw new CustomException("���������ۡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.Guidance , 50))
                throw new CustomException("������ָ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(majorProblems.RiskControlSuggestions , 50))
                throw new CustomException("��Σ�����ؿ��ƽ��顱���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public static int Insert(MajorProblems majorProblems)
        {
            CheckValid(majorProblems);
            return DataAccess.Insert(majorProblems);
        }


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ���������������ţ�CheckId��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public static int Update(MajorProblems majorProblems)
        {
            CheckValid(majorProblems);
            return DataAccess.Update(majorProblems);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public static int Delete(int checkId)
        {
            return DataAccess.Delete(checkId);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId���������ݿ��л�ȡ�ִ潡�������MajorProblems����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�������ִ潡�������MajorProblems����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public static MajorProblems GetDataByCheckId(int checkId)
        {
            return DataAccess.GetDataByCheckId(checkId);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId���������ݿ��л�ȡ�ִ潡�������MajorProblems����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�������ִ潡�������MajorProblems����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public static MajorProblems GetDataByCheckId(string checkId)
        {
            if(!DataValid.IsInt(checkId))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataByCheckId(Convert.ToInt32(checkId));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ�����������ִ潡�������MajorProblems��List�б�
        /// </summary>
        public static List<MajorProblems> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ����ִ潡�������MajorProblems�����б���ҳ��Ϣ��
        /// �÷�������ȡ���ִ潡�������MajorProblems���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
