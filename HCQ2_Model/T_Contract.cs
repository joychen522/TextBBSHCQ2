//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCQ2_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Contract
    {
        public int c_id { get; set; }
        public string RowID { get; set; }
        public string PersonID { get; set; }
        public string UnitID { get; set; }
        public Nullable<int> isModel { get; set; }
        public Nullable<int> sType { get; set; }
        public Nullable<System.DateTime> s1StartDate { get; set; }
        public Nullable<System.DateTime> s1EndDate { get; set; }
        public Nullable<System.DateTime> s1TestStartDate { get; set; }
        public Nullable<System.DateTime> s1TestEndDate { get; set; }
        public Nullable<System.DateTime> s2StartDate { get; set; }
        public Nullable<System.DateTime> s2TestStartDate { get; set; }
        public Nullable<System.DateTime> s2TestEndDate { get; set; }
        public Nullable<System.DateTime> s3StartDate { get; set; }
        public string s3EndReason { get; set; }
        public string post_name { get; set; }
        public string work_address { get; set; }
        public string sWageType { get; set; }
        public Nullable<decimal> s1Wage { get; set; }
        public Nullable<decimal> s2Wage { get; set; }
        public Nullable<decimal> s3Wage { get; set; }
        public Nullable<decimal> s3WagePrice { get; set; }
        public string other_reason { get; set; }
        public Nullable<int> create_id { get; set; }
        public string create_name { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> update_id { get; set; }
        public string update_name { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public byte[] userContract { get; set; }
        public string witheContract { get; set; }
    }
}