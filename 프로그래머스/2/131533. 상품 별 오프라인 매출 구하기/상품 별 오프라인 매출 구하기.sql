SELECT P.PRODUCT_CODE, SUM(P.PRICE * OS.SALES_AMOUNT) SALES

FROM OFFLINE_SALE OS 
INNER JOIN PRODUCT P ON P.PRODUCT_ID = OS.PRODUCT_ID
GROUP BY P.PRODUCT_CODE
ORDER BY SUM(P.PRICE * OS.SALES_AMOUNT) DESC, P.PRODUCT_CODE ASC

