# Instruções de utilização

## Instalação

### Plataforma de Desenvolvimento
- Microsoft Visual Studio Community 2022 (64 bits) - Current Versão 17.3.6 (Português).

### Framework
Foi utilizado o Framework .NET 5.0

### Pacotes/Dépendências.
- Microsoft.EntityFrameworkCore - Version 5.0.17
- Microsoft.EntityFrameworkCore.Design - Version 5.0.17
- Microsoft.EntityFrameworkCore.Tools - Version 5.0.17
- BCrypt.Net-Next - Version 4.0.3

### Banco de Dados
Neste etágio de desenvolvimento está sendo utilizado o banco de dados local gerenciado pelo Visual Studio.
Seguir os seguintes passos para configuração:

1. No menu "Ferramentas" clicar em "Gerenciador de Pacotes Nuget" e depois em "Console do Gerenciador de Pacotes"
1. No Console entrar com o comando: `Update-Database`
1. Após a criação do banco de dados a aplicação poderá ser iniciada/depurada.

## Histórico de versões

### [0.1.0] - 29/10/2022
#### Adicionado
- Home Page Padrão
- FEAT: Cadastro
- FEAT: Login
