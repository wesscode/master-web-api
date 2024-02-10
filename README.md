### Aplicação WebApi em dotnet6
- Boas práticas
- Convenções
- StatusCode 
- REST
- AspNetIdentity com EFCore, JWT, Autorização, Autenticação e Exceptions.
- FluentValidation
- Cors é a permissão que dou para outras aplicações realizarem request na minha api.
- Versionamento
- Documentação swagger
- Observabilidade
    - ILogger
    - Elmah.io / KissLog.net
    - HeathChecks
    - Application Insights(azure)

Elmah.io:
    - Ferramenta de terceiro que configuramos na aplicação aspnet para emitir log em nivel de midleware(exceptions). Com o pacote **Elmah.Io.Extensions.Logging** conseguimos configura-lo para ser um provider do aspnet, conseguindo emitir qualquer log(ILogger).

