using HCQ2_Model;
using HCQ2_Model.TreeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCQ2_IBLL
{
    /// <summary>
    ///  组织机构业务接口定义
    /// </summary>
    public partial interface IT_OrgFolderBLL
    {
        /// <summary>
        ///  获取组织机构目录树数据
        /// </summary>
        /// <returns></returns>
        List<OrgTreeModel> GetOrgTreeData(int user_id=0);
        /// <summary>
        ///  添加节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int AddNode(OrgTreeModel model);
        /// <summary>
        ///  编辑节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        int EditNode(OrgTreeModel model);
        /// <summary>
        ///  删除节点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteNode(T_OrgFolder model, int id);
        /// <summary>
        ///  获取Table数据
        /// </summary>
        /// <param name="model">参数</param>
        /// <param name="total">根据条件返回记录条数</param>
        /// <returns></returns>
        List<T_User> GetTableData(OrgTableParamModel model, out int total);
        /// <summary>
        ///  获取待分配人员数据
        /// </summary>
        /// <returns></returns>
        List<HCQ2_Model.SelectModel.ListBoxModel> GetOrgDataByPerson();
        /// <summary>
        ///  保存组织机构数据设置
        /// </summary>
        /// <param name="personData"></param>
        /// <returns></returns>
        bool SaveOrgDataByPerson(string personData, int folder_id);
        /// <summary>
        ///  获取已分配人员数据
        /// </summary>
        /// <param name="folder_id">组织机构ID</param>
        /// <returns></returns>
        List<HCQ2_Model.SelectModel.ListBoxModel> GetFineOrgDataByPerson(int folder_id);
    }
}
