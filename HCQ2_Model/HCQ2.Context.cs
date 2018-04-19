﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HCQ2Entities : DbContext
    {
        public HCQ2Entities()
            : base("name="+HCQ2_Common.SQL.SqlHelper.VirtualPath)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bane_CriminalRecord> Bane_CriminalRecord { get; set; }
        public virtual DbSet<Bane_FamilyRecord> Bane_FamilyRecord { get; set; }
        public virtual DbSet<Bane_LogDetail> Bane_LogDetail { get; set; }
        public virtual DbSet<Bane_RecoveryInfo> Bane_RecoveryInfo { get; set; }
        public virtual DbSet<Bane_UrinalysisRecord> Bane_UrinalysisRecord { get; set; }
        public virtual DbSet<Bane_UrinalysisTimeSet> Bane_UrinalysisTimeSet { get; set; }
        public virtual DbSet<Bane_User> Bane_User { get; set; }
        public virtual DbSet<BMQ_Document> BMQ_Document { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<T_AreaInfo> T_AreaInfo { get; set; }
        public virtual DbSet<T_AreaPermissRelation> T_AreaPermissRelation { get; set; }
        public virtual DbSet<T_AskManager> T_AskManager { get; set; }
        public virtual DbSet<T_CheckGroup> T_CheckGroup { get; set; }
        public virtual DbSet<T_Complaints> T_Complaints { get; set; }
        public virtual DbSet<T_CompProInfo> T_CompProInfo { get; set; }
        public virtual DbSet<T_Contract> T_Contract { get; set; }
        public virtual DbSet<T_DocFolderPermissRelation> T_DocFolderPermissRelation { get; set; }
        public virtual DbSet<T_DocumentFolder> T_DocumentFolder { get; set; }
        public virtual DbSet<T_DocumentFolderRelation> T_DocumentFolderRelation { get; set; }
        public virtual DbSet<T_DocumentInfo> T_DocumentInfo { get; set; }
        public virtual DbSet<T_DocumentSetType> T_DocumentSetType { get; set; }
        public virtual DbSet<T_ElementPermissRelation> T_ElementPermissRelation { get; set; }
        public virtual DbSet<T_EnterDetail> T_EnterDetail { get; set; }
        public virtual DbSet<T_Equipment> T_Equipment { get; set; }
        public virtual DbSet<T_ExceptionLog> T_ExceptionLog { get; set; }
        public virtual DbSet<T_FilePermissRelation> T_FilePermissRelation { get; set; }
        public virtual DbSet<T_FolderPermissRelation> T_FolderPermissRelation { get; set; }
        public virtual DbSet<T_Function> T_Function { get; set; }
        public virtual DbSet<T_Implement> T_Implement { get; set; }
        public virtual DbSet<T_Instructions> T_Instructions { get; set; }
        public virtual DbSet<T_ItemCode> T_ItemCode { get; set; }
        public virtual DbSet<T_ItemCodeMenum> T_ItemCodeMenum { get; set; }
        public virtual DbSet<T_JobResumeRelation> T_JobResumeRelation { get; set; }
        public virtual DbSet<T_LimitUser> T_LimitUser { get; set; }
        public virtual DbSet<T_Login> T_Login { get; set; }
        public virtual DbSet<T_LogSeting> T_LogSeting { get; set; }
        public virtual DbSet<T_LogSetingDetail> T_LogSetingDetail { get; set; }
        public virtual DbSet<T_MessageNotice> T_MessageNotice { get; set; }
        public virtual DbSet<T_ModulePermissRelation> T_ModulePermissRelation { get; set; }
        public virtual DbSet<T_Org_User> T_Org_User { get; set; }
        public virtual DbSet<T_OrgFolder> T_OrgFolder { get; set; }
        public virtual DbSet<T_OrgUserRelation> T_OrgUserRelation { get; set; }
        public virtual DbSet<T_PageElement> T_PageElement { get; set; }
        public virtual DbSet<T_PageFile> T_PageFile { get; set; }
        public virtual DbSet<T_PageFolder> T_PageFolder { get; set; }
        public virtual DbSet<T_PayAccount> T_PayAccount { get; set; }
        public virtual DbSet<T_PerFuncRelation> T_PerFuncRelation { get; set; }
        public virtual DbSet<T_PermissConfig> T_PermissConfig { get; set; }
        public virtual DbSet<T_Permissions> T_Permissions { get; set; }
        public virtual DbSet<T_Role> T_Role { get; set; }
        public virtual DbSet<T_RoleGroupRelation> T_RoleGroupRelation { get; set; }
        public virtual DbSet<T_RolePermissRelation> T_RolePermissRelation { get; set; }
        public virtual DbSet<T_SetMainPage> T_SetMainPage { get; set; }
        public virtual DbSet<T_Synchronous> T_Synchronous { get; set; }
        public virtual DbSet<T_SysModule> T_SysModule { get; set; }
        public virtual DbSet<T_Table> T_Table { get; set; }
        public virtual DbSet<T_TableField> T_TableField { get; set; }
        public virtual DbSet<T_TodoList> T_TodoList { get; set; }
        public virtual DbSet<T_User> T_User { get; set; }
        public virtual DbSet<T_UserGroup> T_UserGroup { get; set; }
        public virtual DbSet<T_UserGroupRelation> T_UserGroupRelation { get; set; }
        public virtual DbSet<T_UserRoleRelation> T_UserRoleRelation { get; set; }
        public virtual DbSet<T_UserUnitPersonRelation> T_UserUnitPersonRelation { get; set; }
        public virtual DbSet<T_UserUnitRelation> T_UserUnitRelation { get; set; }
        public virtual DbSet<T_UseWorker> T_UseWorker { get; set; }
    
        public virtual int P_CreateDefault(string tableName, string column, string value)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnParameter = column != null ?
                new ObjectParameter("Column", column) :
                new ObjectParameter("Column", typeof(string));
    
            var valueParameter = value != null ?
                new ObjectParameter("Value", value) :
                new ObjectParameter("Value", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_CreateDefault", tableNameParameter, columnParameter, valueParameter);
        }
    
        public virtual int P_CreateIndex(string tableName, string columns, Nullable<bool> unique, Nullable<bool> clustered)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnsParameter = columns != null ?
                new ObjectParameter("Columns", columns) :
                new ObjectParameter("Columns", typeof(string));
    
            var uniqueParameter = unique.HasValue ?
                new ObjectParameter("Unique", unique) :
                new ObjectParameter("Unique", typeof(bool));
    
            var clusteredParameter = clustered.HasValue ?
                new ObjectParameter("Clustered", clustered) :
                new ObjectParameter("Clustered", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_CreateIndex", tableNameParameter, columnsParameter, uniqueParameter, clusteredParameter);
        }
    
        public virtual int P_CreateTable(string tableName, string tableCName, string tableCols, Nullable<bool> drop)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var tableCNameParameter = tableCName != null ?
                new ObjectParameter("TableCName", tableCName) :
                new ObjectParameter("TableCName", typeof(string));
    
            var tableColsParameter = tableCols != null ?
                new ObjectParameter("TableCols", tableCols) :
                new ObjectParameter("TableCols", typeof(string));
    
            var dropParameter = drop.HasValue ?
                new ObjectParameter("Drop", drop) :
                new ObjectParameter("Drop", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_CreateTable", tableNameParameter, tableCNameParameter, tableColsParameter, dropParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
