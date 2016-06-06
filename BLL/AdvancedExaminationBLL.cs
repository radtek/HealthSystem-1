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
    /// �������ƣ��߼�����ҵ���߼��ࣨҵ���߼��㣩
    /// ����˵������������߼�����
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:12:40
    /// </summary>
    public class AdvancedExaminationBLL
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
        internal static DAL.Common.AdvancedExaminationDAL DataAccess
        {
            get
            {
                return DAL.Common.AdvancedExaminationDAL.Instance;
            }
        }


        /// <summary>
        /// �Ը߼�����AdvancedExamination��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public static void CheckValid(AdvancedExamination advancedExamination)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            if (DataValid.IsNull(advancedExamination.Id))
                throw new CustomException("������š�����Ϊ�գ�����ȷ�������Ƿ���ȷ��");

            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(advancedExamination.Oral , 50))
                throw new CustomException("����ǻ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Hearing , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.FMA , 50))
                throw new CustomException("���˶����ܡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Fundus , 50))
                throw new CustomException("���۵ס����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Skin , 50))
                throw new CustomException("��Ƥ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Sclera , 50))
                throw new CustomException("����Ĥ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.LN , 50))
                throw new CustomException("���ܰͽᡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Lung , 50))
                throw new CustomException("���ι��ܡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Heart , 50))
                throw new CustomException("�����ࡱ���Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Abdomen , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.LowerExtremityEdema , 50))
                throw new CustomException("����֫ˮ�ס����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.DPAP , 50))
                throw new CustomException("���㱳�������������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Dre , 50))
                throw new CustomException("������ָ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.FBG , 50))
                throw new CustomException("���ո�Ѫ�ǡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.U_MTB , 50))
                throw new CustomException("����΢�����ס����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.GHb , 50))
                throw new CustomException("���ǻ�Ѫ�쵰�ס����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.HBsAG , 50))
                throw new CustomException("�����͸��ױ��濹ԭ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.ECG , 50))
                throw new CustomException("���ĵ�ͼ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.XRay , 50))
                throw new CustomException("���ز�����Ƭ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.BUltrasonic , 50))
                throw new CustomException("��B�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.CervicalSmear , 50))
                throw new CustomException("������ͿƬ�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Other , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Physical , 50))
                throw new CustomException("�����ʡ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(advancedExamination.Guidance , 50))
                throw new CustomException("������ָ����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public static int Insert(AdvancedExamination advancedExamination)
        {
            CheckValid(advancedExamination);
            return DataAccess.Insert(advancedExamination);
        }


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ���������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public static int Update(AdvancedExamination advancedExamination)
        {
            CheckValid(advancedExamination);
            return DataAccess.Update(advancedExamination);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id���������ݿ��л�ȡ�߼�����AdvancedExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¸߼�����AdvancedExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public static AdvancedExamination GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id���������ݿ��л�ȡ�߼�����AdvancedExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¸߼�����AdvancedExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public static AdvancedExamination GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������и߼�����AdvancedExamination��List�б�
        /// </summary>
        public static List<AdvancedExamination> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ĸ߼�����AdvancedExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ĸ߼�����AdvancedExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
