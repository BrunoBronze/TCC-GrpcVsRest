# Introdução 
O projeto CustomerRelationship.Voucher.Auth.Api é uma API responsável gerar tokens de autenticação para que as demais aplicações sejam aptas a consumir o contexto de Voucher.
Este projeto contém dois tipos de entradas: API Rest e gRPC

# Começando
As instruções a seguir fornecerão as diretrizes para a publicação do projeto, para fins de desenvolvimento e teste.

###	Processo de Instalação
A aplicação terá 2 apresentações: 
- API Rest que será externalizada para outras aplicações
- gRPC que será de uso interno do próprio Voucher

###	Dependência de Softwares/Bancos
 - Jwt
 - Redis 
 - Docker
 - Kubernetes
 
###	Ultima releases
 - Versão Inicial 1.0.0
 
# Pre - requisitos
- [Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/vs/whatsnew/?rr=https%3A%2F%2Fwww.google.com%2F)
- [Visual Studio Code](https://code.visualstudio.com)
- [.Net Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [Docker](https://www.docker.com/)
- [Kubernetes](https://kubernetes.io/docs/tasks/tools/install-kubectl/)
- [ServiceBus] (https://azure.microsoft.com/pt-br/services/service-bus/)
- [Redis] (https://redis.io/)
- [Jwt] (https://jwt.io/)

# Arquitetura
###	Fluxo de processamento
O projeto terá uma Api e um gRPC como entradas.</br>
A Api é responsável por gerar um token JWT contendo a autorização para consumo das aplicações do Voucher.</br>
O gRPC é responsável por gerar um token JWT contendo a mesma autorização mas também com a chave do Redis que armazenará a autenticação da Navitaire.

###	Infraestrutura
A aplicação será executada dentro de containers no Kubernetes</br>
A aplicação também subirá um pod do Redis</br>
A API e o gRPC possui pods separados com comunicação para o Redis</br>
O gRPC possui comunicação via API Rest com o projeto CustomerRelationship.Authentication.

# Criação da chave criptografada sha1

o sha1 é feito a partir da mascara
# ##appName-secretKeyApp-secretKeyAuth##
secretKeyAuth está no appsettings do authentication onde caad ambiente tem seu valor criptografado
secretKeyApp é do app - é a chave que queremos que seja utilizado como secretKey do app
appName seria só o nome do projeto
Exemplo do alerts o sha1 é feito assim
# ##alerts-1234-ed82378f2d6141f38f28d9519d42c##

# Build e Test
Para realizar o build do projeto é necessário acessar o diretório do projeto através de um console.

CustomerRelationship.Voucher.Auth.Api

É necessário navegar ate a pasta que tenha o arquivo .sln e executar comando
```bash
dotnet build 
```
ou
```bash
dotnet test
```

# Contribuição
Por favor, este documento deve ser atualizado com informações relevantes, identificadas durante desenvolvimento e manutenções.

::: Para auxilio de syntax acesse [guidelines](https://docs.microsoft.com/pt-br/azure/devops/project/wiki/markdown-guidance?view=azure-devops) 