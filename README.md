if exists (
    select 1 
    from App_Online_Wages_Details a1
    inner join App_Online_Wages a2 
        on a2.V_CODE = a1.VendorCode 
        and a2.PROC_MONTH = a1.PROC_MONTH 
        and a2.STATUS = 'Request Closed'
    where a1.VendorCode = '11408' 
        and a1.WorkOrderNo = '2500011892' 
        and a1.PROC_MONTH = '202406'
)
begin
    select '202406' as procMonth, '2500011892' as WO_NO, 'Y' as wages;
end
else if exists (
    select 1 
    from App_Online_Wages_Details_Supplement a1
    inner join App_Online_WagesSupplement a2 
        on a2.V_CODE = a1.VendorCode 
        and a2.PROC_MONTH = a1.PROC_MONTH 
        and a2.STATUS = 'Request Closed'
    where a1.VendorCode = '11408' 
        and a1.WorkOrderNo = '2500011892' 
        and a1.PROC_MONTH = '202406'
)
begin
    select '202406' as procMonth, '2500011892' as WO_NO, 'Y' as wages;
end
else
begin
    select '202406' as procMonth, '2500011892' as WO_NO, 'N' as wages;
end
