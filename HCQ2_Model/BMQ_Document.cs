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
    
    public partial class BMQ_Document
    {
        public string RowID { get; set; }
        public string CatalogModule { get; set; }
        public string CatalogID { get; set; }
        public string DocID { get; set; }
        public string DocTitle { get; set; }
        public string DocContent { get; set; }
        public Nullable<System.DateTime> DocPublishDate { get; set; }
        public string DocAuthor { get; set; }
        public string DocNumber { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string Timeliness { get; set; }
        public Nullable<System.DateTime> ExecDate { get; set; }
        public string DocOrg { get; set; }
        public Nullable<System.DateTime> DisableDate { get; set; }
        public string DocYear { get; set; }
        public string DocLevel { get; set; }
        public string DocGroupValue { get; set; }
        public string DocGroupText { get; set; }
        public string PublishState { get; set; }
        public Nullable<long> TotalViews { get; set; }
        public string IsActivity { get; set; }
        public byte[] DocAttach { get; set; }
        public byte[] DocImage { get; set; }
        public string IsHotDoc { get; set; }
        public Nullable<int> DispOrder { get; set; }
    }
}
