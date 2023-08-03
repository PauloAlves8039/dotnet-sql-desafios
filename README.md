<h1 align="center">Desafios</h1>

Repositório com respostas para 3 desafios propostos utilizando a linguagem C# e scripts SQL  

## ✔️ Recursos Utilizados

- ``C#``
- ``SQL Server``

## 🔨 Funcionalidades do projeto

### Desafio 1
Utilizando o array **[7, 5, 3, 9, 6, 4, 1]**, faça o código para percorrer a lista, localizar e substituir o valor **9** por **5** e remover o valor **4** da lista. Ao final você deve apresentar na tela a lista original com a nova lista e a soma dos valores da nova lista.

[Solução - Desafio 1](https://github.com/PauloAlves8039/dotnet-sql-desafios/blob/master/src/Desafios.Tarefa1/Program.cs)


##

### Desafio 2
Analise o cenário a seguir:

`Query 1`

```
SELECT COUNT(Codigo) as Total 
FROM Pedido;

Total = 100
```

`Query 2`

```
SELECT COUNT(Codigo) as Total123 
FROM Pedido 
WHERE CodigoComprador = 123;

Total123 = 15
```
Dado o resulado acima, qual será o resultado do SQL abaixo?

```
SELECT COUNT(Codigo) as TotalFinal FROM Pedido WHERE CodigoComprador <> 123
```
[Solução - Desafio 2](https://github.com/PauloAlves8039/dotnet-sql-desafios/blob/master/src/Desafios.Tarefa2/Tarefa2.sql)

##

### Desafio 3
Desenvolva um algoritmo que, dado um conjunto de números inteiros, retorne o índice da posição da soma de dois números desse conjunto. Você pode assumir que cada conjunto de números tem apenas uma solução, e você não pode usar o mesmo número duas vezes. 
Exemplo:

Entrada: **[2, 7, 11, 15]**
<br/>
Possíveis resultados (você só precisa resolver um):
<br/>

`Resultado 1
`
```
Soma da entrada: 9
9 é a soma de 2 + 7

2 + 7 são os números encontrados no array de entrada
```

`Resultado 2
`
```
Soma da entrada: 22
22 é a soma de 7 + 15
```
[Solução - Desafio 3](https://github.com/PauloAlves8039/dotnet-sql-desafios/blob/master/src/Desafios.Tarefa3/Program.cs)
## :floppy_disk: Clonar Repositório

`git clone https://github.com/PauloAlves8039/dotnet-sql-desafios.git`

## Author

:boy: [Paulo Alves](https://github.com/PauloAlves8039)
