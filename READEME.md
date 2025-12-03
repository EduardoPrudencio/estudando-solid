# 🏛️ Princípios SOLID com C# - Guia Prático

Este projeto serve como um laboratório de estudo sobre Arquitetura de Software, focando na implementação prática dos princípios SOLID em .NET.

Abaixo, um resumo de cada princípio e como eles foram aplicados no nosso código.

---

## 1. SRP - Single Responsibility Principle (Princípio da Responsabilidade Única)
> *"Uma classe deve ter um, e apenas um, motivo para mudar."*

**O Problema:**
Tínhamos uma classe `PedidoViolacao` que fazia tudo: geria itens, calculava total, salvava no banco e enviava e-mail.

**A Solução:**
Dividimos as responsabilidades em componentes especialistas:
* **`Pedido` (Entidade):** Cuida apenas das regras de negócio (adicionar itens, calcular total).
* **`IPedidoRepository`:** Cuida da persistência de dados.
* **`IEmailService`:** Cuida do envio de notificações.

---

## 2. OCP - Open/Closed Principle (Princípio Aberto/Fechado)
> *"Entidades de software devem estar abertas para extensão, mas fechadas para modificação."*

**O Problema:**
A classe `CalculadoraDeDesconto` precisava ser editada (com novos `if/else`) toda vez que surgia um novo tipo de cliente (Vip, Premium, Gold).

**A Solução:**
Usamos o **Strategy Pattern**:
* Criamos a interface `IDescontoStrategy`.
* Cada regra de desconto virou uma classe isolada (`DescontoVipStrategy`, `DescontoComumStrategy`).
* A calculadora agora apenas executa a estratégia recebida, sem precisar conhecer a regra específica.
* Para gerenciar a criação, usamos uma `DescontoFactory`.

---

## 3. LSP - Liskov Substitution Principle (Princípio da Substituição de Liskov)
> *"As classes derivadas devem ser substituíveis por suas classes base sem quebrar o sistema."*

**O Problema:**
A classe `Ebook` herdava de `Item`, mas era obrigada a ter um `Peso`. Ao chamar `CalcularPeso()` em um Ebook, o sistema lançava uma exceção, quebrando a confiança na herança.

**A Solução:**
Reestruturamos a hierarquia:
* `Item`: Classe base com propriedades comuns (Preço).
* `ItemFisico`: Especialização que adiciona o contrato de `Peso`.
* `Ebook`: Herda de `Item` (não tem peso).
* `Livro`: Herda de `ItemFisico` (tem peso).
Agora, podemos substituir `ItemFisico` por `Livro` sem medo de erros surpresa.

---

## 4. ISP - Interface Segregation Principle (Princípio da Segregação de Interface)
> *"Muitas interfaces específicas são melhores do que uma interface única geral."*

**O Problema:**
Uma interface `IProdutoGeral` forçava classes a implementar métodos que não usavam (ex: `Ebook` tendo que implementar `GetEnderecoEntrega`).

**A Solução:**
Quebramos o contrato em interfaces menores e coesas:
* `IProdutoDigital`: Para itens que têm download.
* `IItemFisico`: Para itens que têm peso.
* `ILivro`: Para itens que têm ISBN.
Assim, cada classe implementa apenas o que realmente faz sentido para o seu contexto.

---

## 5. DIP - Dependency Inversion Principle (Princípio da Inversão de Dependência)
> *"Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações."*

**O Problema:**
O `PedidoService` instanciar diretamente uma classe concreta (ex: `new SqlServerRepository()`) criaria um acoplamento forte com o banco de dados.

**A Solução:**
Aplicamos Injeção de Dependência:
* O `PedidoService` pede uma interface `IPedidoRepository` no seu construtor.
* Ele não sabe se os dados vêm do SQL, Mongo ou Arquivo. Ele depende da **abstração** (o contrato), não da implementação.