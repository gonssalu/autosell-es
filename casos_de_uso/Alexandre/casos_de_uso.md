# Casos de uso

- [Caso de uso "Consultar veículo"](#caso-de-uso-consultar-veículo)
- [Caso de uso "Adicionar veículo"](#caso-de-uso-adicionar-veículo)
- [Caso de uso "Editar veículo"](#caso-de-uso-editar-veículo)
- [Caso de uso "Remover veículo"](#caso-de-uso-remover-veículo)
- [Caso de uso "Vender veículo"](#caso-de-uso-vender-veículo)
- [Caso de uso "Comprar veículo"](#caso-de-uso-comprar-veículo)
- [Caso de uso "Troca de veículos"](#caso-de-uso-troca-de-veículos)
- [Caso de uso "Ver histórico de transações"](#caso-de-uso-ver-histórico-de-transações)
- [Caso de uso "Registar um cliente novo"](#caso-de-uso-registar-um-cliente-novo)
- [Caso de uso "Editar dados de um cliente"](#caso-de-uso-editar-dados-de-um-cliente)

## Caso de uso "Consultar veículo"

```css
1. O utilizador clica no botão "Veículos" na janela principal
2. O sistema apresenta o ecrã "Gerir Veículos" na janela principal
3. O utilizador seleciona o veículo que deseja consultar e clica no botão "Consultar"
4. O sistema abre a janela "Consultar Veículo" com os dados do veículo
```

### Caminhos alternativos

```css
3.1   O utilizador clica no botão "Consultar" sem selecionar um veículo
3.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 3 do caso de uso
```

## Caso de uso "Adicionar veículo"

```css
1. O utilizador clica no botão "Veículos" na janela principal
2. O sistema apresenta o ecrã "Gerir Veículos" na janela principal
3. O utilizador clica no botão "Adicionar" no ecrã "Gerir Veículos"
4. O sistema abre a janela "Adicionar Veículo"
5. O utilizador preenche os campos com os dados do veículo e clica no botão "Adicionar"
6. O sistema valida os dados inseridos, cria um veículo com esses dados, atualiza a lista de veículos no ecrã "Gerir Veículos", mostra uma mensagem de sucesso e fecha a janela "Adicionar Veículo"
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Voltar"
5.1.1 O sistema fecha a janela "Adicionar Veículo"
5.2   O utilizador não preenche os campos obrigatórios e clica no botão "Adicionar"
5.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.1   Os dados inseridos são inválidos
6.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.2   Ocorreu um erro ao guardar os dados.
6.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Editar veículo"

```css
1. O utilizador clica no botão "Veículos" na janela principal
2. O sistema apresenta o ecrã "Gerir Veículos" na janela principal
3. O utilizador seleciona o veículo que deseja editar e clica no botão "Editar"
4. O sistema abre a janela "Editar Veículo" com os dados do veículo
5. O utilizador altera os dados do veículo e clica no botão "Editar"
6. O sistema valida os dados inseridos, atualiza os dados do veículo, atualiza a lista de veículos no ecrã "Gerir Veículos", mostra uma mensagem de sucesso e fecha a janela "Editar Veículo"
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Voltar"
5.1.1 O sistema fecha a janela "Editar Veículo"
5.2   O utilizador limpa os campos obrigatórios e clica no botão "Editar"
5.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.1   Os dados inseridos são inválidos
6.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.2   Ocorreu um erro ao guardar os dados.
6.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Remover veículo"

```css
1. O utilizador clica no botão "Veículos" na janela principal
2. O sistema apresenta o ecrã "Gerir Veículos" na janela principal
3. O utilizador seleciona o veículo que deseja remover e clica no botão "Remover"
4. O sistema abre uma janela de confirmação de remoção do veículo
5. O utilizador clica no botão "Sim" na janela de confirmação de remoção do veículo
6. O sistema remove o veículo da lista de veículos, atualiza a lista de veículos no ecrã "Gerir Veículos", mostra uma mensagem de sucesso e fecha a janela de confirmação de remoção do veículo
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Não"
5.1.1 O sistema fecha a janela de confirmação de remoção do veículo
6.1   Ocorreu um erro ao remover o veículo.
6.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Vender veículo"

```css
1. O utilizador clica no botão "Transações" na janela principal
2. O sistema apresenta o ecrã "Transações" na janela principal
3. O utilizador clica no botão "Venda" no ecrã "Transações"
4. O sistema abre a janela "Vender Veículo"
5. O utilizador seleciona o veículo a vender e o cliente alvo da venda, preenche o valor da venda e clica no botão "Preparar veículo"
6. O sistema abre a janela "Preparar Veículo"
7. O utilizador seleciona as peças a utilizar e clica no botão "Preparar"
8. O sistema usa as peças e fecha a janela "Preparar Veículo"
9. O utilizador clica no botão "Vender" na janela "Vender Veículo"
10. O sistema valida os dados inseridos, atualiza a lista de transações no ecrã "Transações", mostra uma mensagem de sucesso e fecha a janela "Vender Veículo"
```

### Caminhos alternativos

```css
5.1    O utilizador clica no botão "Voltar"
5.1.1  O sistema fecha a janela "Vender Veículo"
5.2    O utilizador clica no botão "Novo cliente"
5.2.1  O sistema invoca o caso de uso "Registar um cliente novo" a partir do ponto 4
5.2.2  O utilizador seleciona o cliente acabado de registar, o veículo, preenche o valor da venda e clica no botão "Preparar veículo"
7.1    O utilizador clica no botão "Voltar"
7.1.1  O sistema fecha a janela "Preparar Veículo"
9.1    O utilizador não preenche os dados obrigatórios e clica no botão "Vender"
9.1.1  O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
10.1   Os dados inseridos são inválidos
10.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
10.2   Ocorreu um erro ao guardar os dados.
10.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Comprar veículo"

```css
1. O utilizador clica no botão "Transações" na janela principal
2. O sistema apresenta o ecrã "Transações" na janela principal
3. O utilizador clica no botão "Comprar" no ecrã "Transações"
4. O sistema abre a janela "Comprar Veículo"
5. O utilizador clica no botão "Registar veículo"
6. O sistema invoca o caso de uso "Adicionar veículo" a partir do ponto 4
7. O utilizador seleciona um dos clientes já registados e clica no botão "Comprar"
8. O sistema valida os dados inseridos, cria uma transação com esses dados, atualiza a lista de transações no ecrã "Transações", mostra uma mensagem de sucesso e fecha a janela "Comprar Veículo"
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Voltar"
5.1.1 O sistema fecha a janela "Comprar Veículo"
7.1   O utilizador clica no botão "Novo cliente"
7.1.1 O sistema invoca o caso de uso "Registar um cliente novo" a partir do ponto 4
8.1   O utilizador não preenche os dados obrigatórios e clica no botão "Vender"
8.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
8.2   Ocorreu um erro ao guardar os dados.
8.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Troca de veículos"
  
```css
1.  O utilizador clica no botão "Transações" na janela principal
2.  O sistema apresenta o ecrã "Transações" na janela principal
3.  O utilizador clica no botão "Troca" no ecrã "Transações"
4.  O sistema abre a janela "Troca de Veículos"
5.  O utilizador seleciona o veículo a enviar
6.  O utilizador clica no botão "Registar Veículo" de modo a registar o veículo a receber
7.  O sistema invoca o caso de uso "Adicionar veículo" a partir do ponto 4.
8.  O utilizador seleciona o cliente alvo da troca, preenche o valor da troca e clica no botão "Preparar Veículo"
9.  O sistema abre a janela "Preparar Veículo"
10. O utilizador seleciona as peças a utilizar e clica no botão "Preparar"
11. O sistema fecha a janela "Preparar Veículo"
12. O utilizador clica no botão "Efetuar troca" na janela "Troca de Veículos"
13. O sistema valida os dados inseridos, atualiza a lista de transações no ecrã "Transações", mostra uma mensagem de sucesso e fecha a janela "Troca de Veículos"
```

### Caminhos alternativos

```css
5.1    O utilizador clica no botão "Voltar"
5.1.1  O sistema fecha a janela "Troca de Veículos"
10.1   O utilizador clica no botão "Voltar"
10.1.1 O sistema fecha a janela "Preparar Veículo"
13.1   Os dados inseridos são inválidos
13.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 8 do caso de uso
```

## Caso de uso "Ver histórico de transações"

```css
1. O utilizador clica no botão "Transações" na janela principal
2. O sistema apresenta o ecrã "Transações" na janela principal
3. O utilizador consulta o histórico de transações
```

## Caso de uso "Registar um cliente novo"

```css
1. O utilizador clica no botão "Clientes" na janela principal
2. O sistema apresenta o ecrã "Gerir Clientes" na janela principal
3. O utilizador clica no botão "Adicionar cliente" no ecrã "Gerir Clientes"
4. O sistema abre a janela "Adicionar Cliente"
5. O utilizador preenche os campos com os dados do cliente e clica no botão "Adicionar"
6. O sistema valida os dados inseridos, cria um cliente com esses dados, atualiza a lista de clientes no ecrã "Gerir Clientes", mostra uma mensagem de sucesso e fecha a janela "Adicionar Cliente"
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Voltar"
5.1.1 O sistema fecha a janela "Adicionar Cliente"
5.2   O utilizador não preenche os campos obrigatórios e clica no botão "Adicionar"
5.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.1   Os dados inseridos são inválidos
6.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.2   Ocorreu um erro ao guardar os dados.
6.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```

## Caso de uso "Editar dados de um cliente"

```css
1. O utilizador clica no botão "Clientes" na janela principal
2. O sistema apresenta o ecrã "Gerir Clientes" na janela principal
3. O utilizador seleciona o cliente que deseja editar e clica no botão "Editar"
4. O sistema abre a janela "Editar Cliente" com os dados do cliente
5. O utilizador altera os dados do cliente e clica no botão "Editar"
6. O sistema valida os dados inseridos, atualiza os dados do cliente, atualiza a lista de clientes no ecrã "Gerir Clientes", mostra uma mensagem de sucesso e fecha a janela "Editar Cliente"
```

### Caminhos alternativos

```css
5.1   O utilizador clica no botão "Voltar"
5.1.1 O sistema fecha a janela "Editar Cliente"
5.2   O utilizador limpa os campos obrigatórios e clica no botão "Editar"
5.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.1   Os dados inseridos são inválidos
6.1.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
6.2   Ocorreu um erro ao guardar os dados.
6.2.1 O sistema mostra uma mensagem de erro e volta ao ponto 5 do caso de uso
```
