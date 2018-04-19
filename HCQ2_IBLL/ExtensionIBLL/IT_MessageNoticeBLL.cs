using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCQ2_Model;
using HCQ2_Model.ViewModel;

namespace HCQ2_IBLL
{
    public partial interface IT_MessageNoticeBLL
    {
        /// <summary>
        /// 获取所有的新闻公告
        /// </summary>
        /// <returns></returns>
        List<T_MessageNotice> GetAllMess();
        /// <summary>
        /// 根据用户ID获取自己发布的新闻公告
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        List<T_MessageNotice> GetByUserId(int user_id);
        /// <summary>
        /// 根据主键ID获取新闻公告
        /// </summary>
        /// <param name="mess_id"></param>
        /// <returns></returns>
        T_MessageNotice GetByMessId(int mess_id);
        /// <summary>
        /// 获取页面显示的数据源
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        TableModel GetPageModle(object obj);
        /// <summary>
        /// 新增或者是编辑新闻公告
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool UpdateMess(object obj);
        /// <summary>
        /// 删除新闻公告
        /// </summary>
        /// <param name="mess_id"></param>
        /// <returns></returns>
        bool DeleteMess(int mess_id);

        #region APP接口

        /// <summary>
        /// 分页获取新闻或者通知
        /// </summary>
        /// <param name="notice"></param>
        /// <param name="type">0:新闻  1:通知</param>
        /// <returns></returns>
        List<HCQ2_Model.AppModel.Message> GetPageRowList(HCQ2_Model.AppModel.NoticeModel notice,string appUrl);

        /// <summary>
        /// 根据类别获取新闻通知
        /// </summary>
        /// <returns></returns>
        List<HCQ2_Model.AppModel.Message> GetNoticeByType(HCQ2_Model.AppModel.NoticeModel notice, string appUrl);

        #endregion
    }
}
