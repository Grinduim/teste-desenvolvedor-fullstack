[![](https://bitys.com.br/wp-content/uploads/2024/01/Logo-colorido-medio.png)](https://bitys.com.br)

# Teste para candidatos à vaga de Desenvolvedor FullStack

Olá caro desenvolvedor, nesse teste analisaremos seu conhecimento geral e inclusive velocidade de desenvolvimento. Abaixo explicaremos tudo o que será necessário.

## Instruções

O Desafio é cliar uma aplicação ASP.NET Core Web API e o front-end em ReactJS ou Next.js.

### Back-End

Crie um projeto do tipo ASP.NET Core Web API.
Atache o banco SQL da pasta database (Em caso de dúvidas: https://learn.microsoft.com/pt-br/aspnet/mvc/overview/getting-started/introduction/creating-a-connection-string#sql-server-express-localdb).

Crie uma API Rest de usuários e perfis.
A entidade de perfis, devem existir as propriedades abaixo:

- id
- nome
- situação | ativo/inativo

Adicione na migration, uma carga com 3 perfis, sendo Admin, Vendedor e Gerente. Todos como ativo.
Crie a api de perfis, apenas com o método para retornar todos. Esse endpoint será utilizado no cadastro de usuários no front-end.

Já para usuários, a api deverá possuir os endpints para criar, excluir e alterar. Além de buscar todos e por id (na busca não deverá retornar a senha do usuário). Na entidade de usuário, devem existir as propriedades abaixo:

- id
- nome | obrigatório
- cpf | obrigatório
- e-mail | obrigatório
- data_nasc | obrigatório
- idioma
- senha
- situação | ativo/inativo | obrigatório

Utilize o Entity Framework e Migrations para as alterações de banco de dados.

### Front-End

A partir do layout e imagens disponibilizadas (pasta layout e images), você deve implementar uma página web com o mesmo conteúdo, e que seja responsivo.

O projeto deverá ser construído utilizando a tecnologia ReactJS ou Next.js. Para o layout, recomendamos bootstrap ou tailwind.

O conteúdo deverá ser lido da api implementada no tópico acima.
Priorize o desenvolvimento da listagem(grid) dos dados e inclusão.

## Itens avaliados

- Nível de funcionamento dos projetos (api e front-end).
- (back-end) - Aplicação dos conceitos da orientação a objetos.
- (back-end) - Respeito aos princípios do SOLID.
- (back-end) - Aplicação do DDD.
- (front-end) - Nível de semelhança do layout com o que foi solicitado (pasta layout).
- (front-end) - Responsividade do layout.
- (front-end) - Validação de campos obrigatórios.

### Conclusão

Após finalizar o desenvolvimento e testes, publique em seu GIT todos os arquivos, incluindo o banco de dados e envie o link do repositório para o gestor técnico responsável pelo processo seletivo.

### Boa sorte!
