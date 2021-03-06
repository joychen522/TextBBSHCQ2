﻿
    using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;
   namespace HCQ2_IDAL
   {
   public partial interface IDBSession
   {
   		IBane_CriminalRecordDAL IBane_CriminalRecordDAL{get;set;}
				IBane_FamilyRecordDAL IBane_FamilyRecordDAL{get;set;}
				IBane_LogDetailDAL IBane_LogDetailDAL{get;set;}
				IBane_RecoveryInfoDAL IBane_RecoveryInfoDAL{get;set;}
				IBane_UrinalysisRecordDAL IBane_UrinalysisRecordDAL{get;set;}
				IBane_UrinalysisTimeSetDAL IBane_UrinalysisTimeSetDAL{get;set;}
				IBane_UserDAL IBane_UserDAL{get;set;}
				IBMQ_DocumentDAL IBMQ_DocumentDAL{get;set;}
				IsysdiagramsDAL IsysdiagramsDAL{get;set;}
				IT_AreaInfoDAL IT_AreaInfoDAL{get;set;}
				IT_AreaPermissRelationDAL IT_AreaPermissRelationDAL{get;set;}
				IT_AskManagerDAL IT_AskManagerDAL{get;set;}
				IT_CheckGroupDAL IT_CheckGroupDAL{get;set;}
				IT_ComplaintsDAL IT_ComplaintsDAL{get;set;}
				IT_CompProInfoDAL IT_CompProInfoDAL{get;set;}
				IT_ContractDAL IT_ContractDAL{get;set;}
				IT_DocFolderPermissRelationDAL IT_DocFolderPermissRelationDAL{get;set;}
				IT_DocumentFolderDAL IT_DocumentFolderDAL{get;set;}
				IT_DocumentFolderRelationDAL IT_DocumentFolderRelationDAL{get;set;}
				IT_DocumentInfoDAL IT_DocumentInfoDAL{get;set;}
				IT_DocumentSetTypeDAL IT_DocumentSetTypeDAL{get;set;}
				IT_ElementPermissRelationDAL IT_ElementPermissRelationDAL{get;set;}
				IT_EnterDetailDAL IT_EnterDetailDAL{get;set;}
				IT_EquipmentDAL IT_EquipmentDAL{get;set;}
				IT_ExceptionLogDAL IT_ExceptionLogDAL{get;set;}
				IT_FilePermissRelationDAL IT_FilePermissRelationDAL{get;set;}
				IT_FolderPermissRelationDAL IT_FolderPermissRelationDAL{get;set;}
				IT_FunctionDAL IT_FunctionDAL{get;set;}
				IT_ImplementDAL IT_ImplementDAL{get;set;}
				IT_InstructionsDAL IT_InstructionsDAL{get;set;}
				IT_ItemCodeDAL IT_ItemCodeDAL{get;set;}
				IT_ItemCodeMenumDAL IT_ItemCodeMenumDAL{get;set;}
				IT_JobResumeRelationDAL IT_JobResumeRelationDAL{get;set;}
				IT_LimitUserDAL IT_LimitUserDAL{get;set;}
				IT_LoginDAL IT_LoginDAL{get;set;}
				IT_LogSetingDAL IT_LogSetingDAL{get;set;}
				IT_LogSetingDetailDAL IT_LogSetingDetailDAL{get;set;}
				IT_MessageNoticeDAL IT_MessageNoticeDAL{get;set;}
				IT_ModulePermissRelationDAL IT_ModulePermissRelationDAL{get;set;}
				IT_Org_UserDAL IT_Org_UserDAL{get;set;}
				IT_OrgFolderDAL IT_OrgFolderDAL{get;set;}
				IT_OrgUserRelationDAL IT_OrgUserRelationDAL{get;set;}
				IT_PageElementDAL IT_PageElementDAL{get;set;}
				IT_PageFileDAL IT_PageFileDAL{get;set;}
				IT_PageFolderDAL IT_PageFolderDAL{get;set;}
				IT_PayAccountDAL IT_PayAccountDAL{get;set;}
				IT_PerFuncRelationDAL IT_PerFuncRelationDAL{get;set;}
				IT_PermissConfigDAL IT_PermissConfigDAL{get;set;}
				IT_PermissionsDAL IT_PermissionsDAL{get;set;}
				IT_RoleDAL IT_RoleDAL{get;set;}
				IT_RoleGroupRelationDAL IT_RoleGroupRelationDAL{get;set;}
				IT_RolePermissRelationDAL IT_RolePermissRelationDAL{get;set;}
				IT_SetMainPageDAL IT_SetMainPageDAL{get;set;}
				IT_SynchronousDAL IT_SynchronousDAL{get;set;}
				IT_SysModuleDAL IT_SysModuleDAL{get;set;}
				IT_TableDAL IT_TableDAL{get;set;}
				IT_TableFieldDAL IT_TableFieldDAL{get;set;}
				IT_TodoListDAL IT_TodoListDAL{get;set;}
				IT_UserDAL IT_UserDAL{get;set;}
				IT_UserGroupDAL IT_UserGroupDAL{get;set;}
				IT_UserGroupRelationDAL IT_UserGroupRelationDAL{get;set;}
				IT_UserRoleRelationDAL IT_UserRoleRelationDAL{get;set;}
				IT_UserUnitPersonRelationDAL IT_UserUnitPersonRelationDAL{get;set;}
				IT_UserUnitRelationDAL IT_UserUnitRelationDAL{get;set;}
				IT_UseWorkerDAL IT_UseWorkerDAL{get;set;}
			}
}