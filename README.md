 IF 
  select '202406' as procMonth, WO_NO,( select top 1 case when count(*) >0 then 'Y' else 'N' end from App_Online_Wages_Details a1 
 inner join App_Online_Wages a2 on a2.V_CODE=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.STATUS = 'Request Closed' 
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' )
 as wages,
 ELSE  select '202406' as procMonth, WO_NO,( select top 1 case when count(*) >0 then 'Y' else 'N' end from App_Online_Wages_Details_Supplement a1 
 inner join App_Online_WagesSupplement a2 on a2.V_CODE=a1.VendorCode and a2.PROC_MONTH =a1.PROC_MONTH and a2.STATUS = 'Request Closed' 
 where a1.VendorCode='11408' AND a1.WorkOrderNo='2500011892' and a1.PROC_MONTH ='202406' )
 as wages,
