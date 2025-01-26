# 🚀 RNT Website com Umbraco CMS

Bem-vindo ao **RNT Website**! 🎉 Este é um projeto desenvolvido utilizando **Umbraco CMS**, uma plataforma poderosa e flexível para gerenciamento de conteúdo. Ele foi projetado para ser simples de clonar, configurar e rodar localmente.

## ⚙️ Tecnologias Utilizadas

Este projeto utiliza a seguinte tecnologia:

- **Umbraco CMS**: Sistema de gerenciamento de conteúdo flexível e baseado em .NET, que facilita a criação e gestão de websites.

## 💻 Como Rodar o Projeto Localmente

Aqui estão os passos para rodar o projeto na sua máquina local. Vamos fazer isso passo a passo para garantir que tudo funcione bem!

### 1. Pré-requisitos

Antes de começar, verifique se você tem o **.NET SDK** instalado. Caso não tenha, baixe a versão mais recente do SDK [aqui](https://dotnet.microsoft.com/download).

E também instalar o SQLite na sua maquina.

### 1.1 Instalar .NET no MacOS (Caso necessário)

Se estiver usando o MacOS, você pode instalar o .NET via Homebrew com o seguinte comando:

```bash
    brew install dotnet@8
```

### 2. Clonar o Repositório

Você precisa clonar o repositório para a sua máquina local.

### 3. Restaurar Dependências

Antes de rodar o projeto, é necessário restaurar as dependências do Umbraco CMS. Para isso, navegue até o diretório onde o projeto foi clonado e execute o comando:

```bash
    dotnet restore
```

### 4. Correr o projecto

Agora, você pode rodar o projeto localmente. No terminal, estando dentro do diretório do projeto, execute o seguinte comando:

```bash
    dotnet run --project "RNTWebsite"
```

Irá mostrar a url do localhost onde se encontra hospedado localmente.

### Credenciais de Acesso

Para acessar a pagina, de momento use as seguintes credenciais:

```bash
    Email: admin@example.com
    Password: 1234567890
```
