Descrição de Cada Pasta
Controllers/

Contém os controladores que definem os endpoints da API.
Exemplo: PerfilController.cs, UsuarioController.cs.
Regra geral: cada entidade deve ter seu próprio controlador, se necessário.
Data/

Centraliza a configuração do banco de dados e o DbContext.
Exemplo: AppDbContext.cs.
Inclui a lógica de configuração inicial, como seeds e customizações de schema.
Models/

Armazena as classes de modelo (entidades) que mapeiam o banco de dados.
Exemplo: Perfil.cs, Usuario.cs.
Essas classes representam a estrutura das tabelas.
Services/

Armazena lógica de negócios específica.
Use para manter os controladores enxutos.
Exemplo: UsuarioService.cs, PerfilService.cs.
Migrations/

Gerenciada automaticamente pelo Entity Framework Core.
Contém os arquivos de migração para rastrear mudanças no schema do banco de dados.
Utils/ (Opcional)

Contém classes auxiliares ou funções úteis que podem ser reutilizadas em várias partes do projeto.
Exemplo: validações de CPF, geradores de senha, etc.
DTOs/

Armazena objetos de transferência de dados usados para comunicação entre camadas.
Exemplo: UsuarioCreateDto.cs, UsuarioResponseDto.cs.
Isso ajuda a evitar expor diretamente os modelos do banco no front-end.
