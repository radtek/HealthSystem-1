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
    /// �������ƣ���ͥҵ���߼��ࣨҵ���߼��㣩
    /// ����˵������Ϊ�����Ա���ϲ���֯��������ͥ�ж��������ɡ�
    /// ����˵���������ṩ�˸���ҵ���߼����������û�����������ҵ���߼����е�����е��á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:18:21
    /// </summary>
    public class FamilyBLL
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
        internal static DAL.Common.FamilyDAL DataAccess
        {
            get
            {
                return DAL.Common.FamilyDAL.Instance;
            }
        }


        /// <summary>
        /// �Լ�ͥ��Family��ʵ�����󣬽���������Ч�Լ�顣
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public static void CheckValid(Family family)
        {
            #region ���������Ƿ���Ͽ�ֵԼ��
            #endregion

            #region ����ַ����Ƿ񳬳��涨����
            if (DataValid.IsOutLength(family.Name , 50))
                throw new CustomException("����ͥ���ơ����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(family.Owner , 50))
                throw new CustomException("�����������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(family.ResponsibleDoctor , 50))
                throw new CustomException("������ҽ�������Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            if (DataValid.IsOutLength(family.Remark , 50))
                throw new CustomException("����ע�����Ȳ��ܳ��� 50 �����ֻ��ַ�������ȷ�������Ƿ���ȷ��");

            #endregion
        }


        /// <summary>
        /// ����ͥ��Family�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public static int Insert(Family family)
        {
            CheckValid(family);
            return DataAccess.Insert(family);
        }


        /// <summary>
        /// ����ͥ��Family�����ݣ�������������ͥ�����ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public static int Update(Family family)
        {
            CheckValid(family);
            return DataAccess.Update(family);
        }


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id���������ݿ��л�ȡ��ͥ��Family����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¼�ͥ��Family����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public static Family GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id���������ݿ��л�ȡ��ͥ��Family����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¼�ͥ��Family����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public static Family GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("ϵͳ����������ʹ�������ͨ��ϵͳ�ṩ�İ�ť�����ӣ���������ع���ģ�顣", ExceptionType.Error,
                    "��ϸ��Ϣ��ͨ����ɸô����ԭ��Ϊ��������ͨ��ֱ�������ַ������ϵͳ����ع���ģ�����ɡ�����������ȷ������ť������һҳ�棬�������Ժ��Գ��ִ˴���������ϵͳ����Ա��ϵ��");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������м�ͥ��Family��List�б�
        /// </summary>
        public static List<Family> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ļ�ͥ��Family�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ļ�ͥ��Family���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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
