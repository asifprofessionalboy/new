

SELECT  w.MonthWage,W.YearWage,W.AadharNo,W.VendorCode,W.VendorName,W.WorkOrderNo,W.LocationCode,W.LocationNM,W.WorkManCategory,
W.TotPaymentDays,W.BasicWages,W.DAWages,W.TotalWages,

(select top 1 Sex from App_EmployeeMaster where AadharCard=w.AadharNo order by CreatedOn desc) gender,

(select top 1 DEPT_CODE from App_WorkOrder_Reg where WO_NO=w.WorkOrderNo ) DepartmentName D, 
(select top 1 DepartmentCode from App_DepartmentMaster where DepartmentName=D.DepartmentName ) DepartmentCode 

FROM App_WagesDetailsJharkhand w where MonthWage in ('4') and YearWage in ('2024' )
