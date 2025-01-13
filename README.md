-- for wage only

 select '202406' as procMonth, WO_NO,( select top 1 case when count(*) >0 then 'Y' else 'N' end from App_Online_Wages_Details a1 
 inner join App_Online_Wages a2 on a2.V_CODE=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.STATUS = 'Request Closed' 
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' )
 as wages,


 (select top 1 case when count(*) >0 then 'Y' else 'N' end from App_PF_ESI_Details a1 inner join App_PF_ESI_Summary a2
 on a2.VendorCode=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.Status = 'Request Closed' where a1.VendorCode='11408'
 AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' ) as PF,
 


 (select top 1 case when count(*) >0 then 'Y' else 'N' end 
 from App_PF_ESI_Details a1 inner join App_PF_ESI_Summary a2 on a2.VendorCode=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH
 and a2.STATUS = 'Request Closed' where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' ) as ESI,



 (select top 1 case when count(*) >0 then 'Y' else 'N' end from App_LabourLicenseSubmission where Vcode='11408'
 and CONVERT(int, convert(varchar, DATEPART(YEAR,FromDate))+Convert(varchar,FORMAT(DATEPART(month,FromDate), '00')) ) <='202406' 
 and CONVERT(int, convert(varchar, DATEPART(YEAR,ToDate))+Convert(varchar,FORMAT(DATEPART(month,ToDate), '00')) )>='202406' ) 
 as LL from App_Vendorwodetails where WO_NO='2500011892'




 -- for wage Supplement

  select '202406' as procMonth, WO_NO,( select top 1 case when count(*) >0 then 'Y' else 'N' end from App_Online_Wages_Details_Supplement a1 
 inner join App_Online_WagesSupplement a2 on a2.V_CODE=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.STATUS = 'Request Closed' 
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' )
 as wages,


 (select top 1 case when count(*) >0 then 'Y' else 'N' end from App_PF_ESI_Details_Supplement a1 inner join App_PF_ESI_Summary_Supplement a2
 on a2.VendorCode=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.Status = 'Request Closed'
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' ) as PF,
 

 (select top 1 case when count(*) >0 then 'Y' else 'N' end 
 from App_PF_ESI_Details_Supplement a1 inner join App_PF_ESI_Summary_Supplement a2 on a2.VendorCode=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH
 and a2.Status = 'Request Closed'
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' ) as ESI,

 (select top 1 case when count(*) >0 then 'Y' else 'N' end from App_LabourLicenseSubmission where Vcode='11408'
 and CONVERT(int, convert(varchar, DATEPART(YEAR,FromDate))+Convert(varchar,FORMAT(DATEPART(month,FromDate), '00')) ) <='202406' 
 and CONVERT(int, convert(varchar, DATEPART(YEAR,ToDate))+Convert(varchar,FORMAT(DATEPART(month,ToDate), '00')) )>='202406' ) 
 as LL from App_Vendorwodetails where WO_NO='2500011892'
