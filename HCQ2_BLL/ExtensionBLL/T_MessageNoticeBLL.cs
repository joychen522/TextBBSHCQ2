using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HCQ2_Model;
using HCQ2_Model.ViewModel;
using System.Web.Mvc;
using System.Web;

namespace HCQ2_BLL
{
    public partial class T_MessageNoticeBLL : HCQ2_IBLL.IT_MessageNoticeBLL
    {
        /// <summary>
        /// 获取所有的新闻公告
        /// </summary>
        /// <returns></returns>
        public List<T_MessageNotice> GetAllMess()
        {
            return base.Select(o => o.m_id > 0).OrderByDescending(o => o.create_date).ToList();
        }
        /// <summary>
        /// 根据用户ID获取自己发布的新闻公告
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        public List<T_MessageNotice> GetByUserId(int user_id)
        {
            return base.Select(o => o.create_user_id == user_id.ToString()).ToList();
        }
        /// <summary>
        /// 根据主键ID获取新闻公告
        /// </summary>
        /// <param name="mess_id"></param>
        /// <returns></returns>
        public T_MessageNotice GetByMessId(int mess_id)
        {
            return base.Select(o => o.m_id == mess_id).FirstOrDefault();
        }
        /// <summary>
        /// 获取页面显示的数据源
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public TableModel GetPageModle(object obj)
        {
            TableModel modle = new TableModel();
            FormCollection param = (FormCollection)obj;
            int page = int.Parse(param["page"]);
            int rows = int.Parse(param["rows"]);

            var data = GetByUserId(HCQ2UI_Helper.OperateContext.Current.Usr.user_id);

            if (!string.IsNullOrEmpty(param["txtSearchName"]))
            {
                string searchName = param["txtSearchName"];
                data = data.Where(o => o.m_title.Contains(searchName) || o.m_content.Contains(searchName)).ToList();
            }

            modle.total = data.Count();
            modle.rows = data.Skip((rows * page) - rows).Take(rows);

            return modle;
        }
        /// <summary>
        /// 新增或者是编辑新闻公告
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool UpdateMess(object obj)
        {
            FormCollection param = (FormCollection)obj;

            T_MessageNotice mes = new T_MessageNotice();

            mes.m_title = param["m_title"];
            mes.m_type = param["m_type"];
            mes.m_content = param["m_content"];
            mes.create_user_id = HCQ2UI_Helper.OperateContext.Current.Usr.user_id.ToString();
            mes.create_user_name = HCQ2UI_Helper.OperateContext.Current.Usr.user_name;
            mes.create_date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            if (!string.IsNullOrEmpty(param["m_image"]))
            {
                string imagePath = param["m_image"];
                mes.m_image_src = imagePath;
                byte[] str = HCQ2_Common.ImageHelper.ImageToBytes(HttpContext.Current.Server.MapPath(imagePath));
                mes.m_image = str;
            }

            bool isAccess = false;
            if (!string.IsNullOrEmpty(param["mes_id"]))
            {
                //编辑
                int mes_id = int.Parse(param["mes_id"]);
                isAccess = base.Modify(mes, o => o.m_id == mes_id, "m_title", "m_type", "m_content", "m_image") > 0;
            }
            else
                isAccess = base.Add(mes) > 0;

            return isAccess;
        }
        /// <summary>
        /// 删除新闻公告
        /// </summary>
        /// <param name="mess_id"></param>
        /// <returns></returns>
        public bool DeleteMess(int mess_id)
        {
            return base.Delete(o => o.m_id == mess_id) > 0;
        }

        #region APP接口

        /// <summary>
        /// 分页获取新闻或者通知
        /// </summary>
        /// <param name="notice"></param>
        /// <param name="type">0:新闻  1:通知</param>
        /// <returns></returns>
        public List<HCQ2_Model.AppModel.Message> GetPageRowList(HCQ2_Model.AppModel.NoticeModel notice, string appUrl)
        {
            HCQ2_Model.AppModel.Message mes = new HCQ2_Model.AppModel.Message();
            List<HCQ2_Model.AppModel.Message> rlist = new List<HCQ2_Model.AppModel.Message>();
            List<T_MessageNotice> list = new List<T_MessageNotice>();

            T_ItemCodeBLL codeList = new T_ItemCodeBLL();
            T_ItemCodeMenumBLL codeMenuList = new T_ItemCodeMenumBLL();
            string news_type = codeMenuList.GetByItemId(codeList.GetByItemCode("NewsType").item_id).
                Where(o => o.code_value == notice.type).FirstOrDefault()?.code_name;
            var data = GetAllMess().Where(o => o.m_type == news_type).Skip((notice.rows * notice.page) - notice.rows).Take(notice.rows);
            if (data.Count() > 0)
            {
                list = data.ToList();
                foreach (var item in list)
                {
                    mes = new HCQ2_Model.AppModel.Message();
                    mes.notice_title = item.m_title;
                    mes.notice_content = item.m_content;
                    mes.notice_type = item.m_type;
                    mes.notice_image = item.m_image;
                    if (!string.IsNullOrEmpty(item.m_image_src))
                        mes.notice_image_src = appUrl + "/" + item.m_image_src.Replace("~", "");
                    else
                        mes.notice_image_src = "";
                    mes.release_name = item.create_user_name;
                    if (!string.IsNullOrEmpty(item.create_date.ToString()))
                        mes.release_date = Convert.ToDateTime(item.create_date).ToString("yyyy-MM-dd");
                    rlist.Add(mes);
                }
            }
            return rlist;
        }

        /// <summary>
        /// 根据类别获取新闻通知
        /// </summary>
        /// <returns></returns>
        public List<HCQ2_Model.AppModel.Message> GetNoticeByType(HCQ2_Model.AppModel.NoticeModel notice, string appUrl)
        {
            HCQ2_Model.AppModel.Message mes = new HCQ2_Model.AppModel.Message();
            List<HCQ2_Model.AppModel.Message> rlist = new List<HCQ2_Model.AppModel.Message>();
            List<T_MessageNotice> list = new List<T_MessageNotice>();

            T_ItemCodeBLL codeList = new T_ItemCodeBLL();
            T_ItemCodeMenumBLL codeMenuList = new T_ItemCodeMenumBLL();
            string news_type = codeMenuList.GetByItemId(codeList.GetByItemCode("NewsType").item_id).
                Where(o => o.code_value == notice.type).FirstOrDefault()?.code_name;
            var data = GetAllMess().Where(o => o.m_type == news_type).Skip((notice.rows * notice.page) - notice.rows).Take(notice.rows);
            if (data.Count() > 0)
            {
                list = data.ToList();
                foreach (var item in list)
                {
                    mes = new HCQ2_Model.AppModel.Message();
                    mes.notice_title = item.m_title;
                    mes.notice_content = "";
                    mes.notice_type = item.m_type;
                    mes.notice_image = null;
                    mes.notice_image_src = "";
                    mes.release_name = item.create_user_name;
                    if (!string.IsNullOrEmpty(item.create_date.ToString()))
                        mes.release_date = Convert.ToDateTime(item.create_date).ToString("yyyy-MM-dd");
                    rlist.Add(mes);
                }
            }
            return rlist;
        }

        #endregion
    }
}
