-- 코드를 입력하세요
-- FLAVOR 가 동일한 TOTAL_ORDER 의 합이 가장 높은 세 개
-- SHIPMENT ID 필요한 건가??

-- 두 테이블 다 합치고 UNION,
-- GROUP BY FLAVOR SUM TOTAL,
-- ORDER BY TOTAL DESC, LIMIT 3 

SELECT TOTAL_TABLE.FLAVOR 
FROM 
    (SELECT * FROM FIRST_HALF FH
    UNION ALL 
    SELECT * FROM JULY J) AS TOTAL_TABLE
GROUP BY TOTAL_TABLE.FLAVOR 
ORDER BY SUM(TOTAL_TABLE.TOTAL_ORDER) DESC

LIMIT 3 