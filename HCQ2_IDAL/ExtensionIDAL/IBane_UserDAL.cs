﻿using HCQ2_Model.BaneUser;
using HCQ2_Model.WebApiModel.ParamModel;
using System.Collections.Generic;

namespace HCQ2_IDAL
{
    public partial interface IBane_UserDAL
    {
        /// <summary>
        ///  获取戒毒人员一栏数据
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        List<BaneListModel> GetBaneData(BaneListParams param);
        /// <summary>
        ///  统计戒毒人员一栏数据
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        int GetGetBaneDataCount(BaneListParams param);
        /// <summary>
        ///  获取定期尿检记录数据
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        List<BaneProModel> GetBaneProData(BaneListParams param);
        /// <summary>
        ///  统计定期尿检人员数量
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        int GetBaneProDataCount(BaneListParams param);
        /// <summary>
        ///  根据身份证获取数据
        /// </summary>
        /// <param name="user_identify"></param>
        /// <returns></returns>
        BaneAddUser GetBaneUser(string user_identify);
        /// <summary>
        ///  本月应检人数统计
        /// </summary>
        /// <returns></returns>
        int GetCountByMonth(int user_id);
        /// <summary>
        ///  过检人数统计，根据权限
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        int PassCountPerson(int user_id);
        /// <summary>
        ///  统计一周内应到检测人员数量
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        int GetWeekCountPerson(int user_id);

        //**************************************接口*******************************************
        /// <summary>
        /// 获取人员同步数据
        /// </summary>
        /// <param name="userid">用户id</param>
        /// <param name="deviceid">设备编码</param>
        /// <returns></returns>
        List<PersonCL> GetPersonsSynchronousData(int userid, string deviceid);
        /// <summary>
        ///  获取下发所有数据 根据权限
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        List<PersonCL> GetPersonsSentDownData(string userid);
    }
}
