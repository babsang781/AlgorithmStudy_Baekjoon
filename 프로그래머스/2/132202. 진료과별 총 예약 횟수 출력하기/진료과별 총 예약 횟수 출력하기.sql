SELECT MCDP_CD '진료과 코드', COUNT(APNT_YMD) '5월예약건수'
# SELECT MCDP_CD '진료과 코드', APNT_YMD
FROM APPOINTMENT
WHERE APNT_YMD BETWEEN '2022-05-01' AND '2022-05-31'
GROUP BY MCDP_CD
ORDER BY COUNT(APNT_YMD) ASC, MCDP_CD ASC