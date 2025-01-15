select * from ONLINE_TEMP_BONUS where      BONUS_YEAR='2022-2023'

select * from ONLINE_TEMP_BONUS_ATTACHMENT  where  ID=(select ID from ONLINE_TEMP_BONUS where      BONUS_YEAR='2022-2023')   


