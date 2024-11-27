<h1>Banco de Sangue</h1>
<p>Neste Projeto vamos desenvolver um banco de sangue utilizando .net Core, este projeto tem como proposito desenvolver minhas habilidades como programador, Esta API foi projetada para gerenciar bancos de sangue, possibilitando o cadastro de doadores, consultas e controle de estoques </p>

<h3>TECNOLOGIAS</h3>

<ul>
  <li>.NET 8</li>
  <li>Entity Framework Core</li>
  <li>SQL</li>
  <li>Fluent Validator</li>
  <li>Clean Architecture</li>
  <li>Unit Of Work</li> 
  <li>CQRS</li>
  <li>LINQ</li>
  <li>DTO</li>
</ul>

<H3>FUNCIONALIDADES</H3>
<ul>
  <li>Cadastrar Doador </li>
  <li>Cadastrar Doacao </li>
  <li>Cadastrar Endereco Doador </li>
  <li>Cadastrar Estoque Sangue </li>
  <li>Validação Peso, Quantidade sangue doador e Idade e Sexo</li>
</ul>

<H3>ESTRUTURA DO PROJETO</H3>

<p> O projeto segue os princípios da Clean Architecture, com as seguintes camadas </p>

<ul>
  <li><b>Domain:</b> Contém as regras de negócio e entidades principais.</li>
  <li><b>Application:</b> Camada de lógica de aplicação, incluindo DTOs e validações (com FluentValidation planejado).</li>
  <li><b>Infrastructure:</b> Implementação de acesso a dados com o Entity Framework Core.</li>
  <li><b>API:</b> A interface pública para consumidores da aplicação.</li>

</ul>
