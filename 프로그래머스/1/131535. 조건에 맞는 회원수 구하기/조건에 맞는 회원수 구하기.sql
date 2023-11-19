-- 코드를 입력하세요
# SELECT COUNT(USER_ID) USERS
# FROM USER_INFO
# WHERE JOINED LIKE '2021%'
# AND AGE BETWEEN 20 AND 29


SELECT COUNT(USER_ID) USERS
# SELECT * 
FROM USER_INFO
WHERE JOINED BETWEEN '2021-01-01' AND '2021-12-31'
AND AGE BETWEEN 20 AND 29


