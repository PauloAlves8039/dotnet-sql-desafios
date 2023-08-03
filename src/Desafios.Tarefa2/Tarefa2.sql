-- A primeira query vai retornar a contagem de registros para a tabela "Pedido" usando o alias "Total".
SELECT COUNT(Codigo) as Total
FROM Pedido;

-- O seu resultado é: Total = 100

-- A segunda query vai retornar a contagem de registros referentes ao campo "CodigoComprador" para a tabela "Pedido" usando o alias "Total123".
SELECT COUNT(Codigo) as Total123
FROM Pedido 
WHERE CodigoComprador = 123;

-- O seu resultado é: Total123 = 15

-- A terceira query vai trazer a contagem de registos referentes ao campo "CodigoComprador" na tabela "Pedido" usando o alias "TotalFinal" para os valores diferentes de 123.
SELECT COUNT(Codigo) as TotalFinal 
FROM Pedido 
WHERE CodigoComprador <> 123

/*
   Para encontrar o resultado da terceira query "TotalFinal" precisamos subtrair o valor retornado da primeira query "Total" com o valor da segunda query "Total123".
   Com isso encontraremos um total de registros em que o campo "CodigoComprador" tenha valores diferentes de 123.
   
   TotalFinal = 100 - 15  
   Temos o resultado: TotalFinal = 85
*/