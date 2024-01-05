# SOLID

### O que é o SOLID? Qual a vantagem de utilizar os principios do SOLID?

SOLID é um acrônimo para alguns principios de desenvolvimento de sofware orientado a objetos.

* S — Single Responsiblity Principle (Princípio da responsabilidade única)
* O — Open-Closed Principle (Princípio Aberto-Fechado)
* L — Liskov Substitution Principle (Princípio da substituição de Liskov)
* I — Interface Segregation Principle (Princípio da Segregação da Interface)
* D — Dependency Inversion Principle (Princípio da inversão da dependência)

As vantagens de utilizar os principios do SOLID são:
-  Separação de responsabilidades.
-  Diminuição de acoplamentos.
-  Reuso de código.
-  Código mais legível.

## SRP -> Single Responsiblity Principle (Princípio da responsabilidade única)

Basicamente o que isso significa é que uma classe não deve ter vários comportamentos diferentes, começar a validar regras e propriedades de outras classes. Quando uma classe começa a lidar com varias responsabilidades começa a ficar difícil manter.

O ideal é dividirmos as responsabilidades, separar em outras classes e serviços, para que simplifique a forma de manter o código e reutilizar caso necessário.

1. Diretório com exemplo de SRP
```
src\SRP
```
Dentro desse diretório existem 2 projetos console exemplificando as práticas de SRP.
- Bad = O que não fazer!
- Good = Bons exemplos do que podemos fazer!

![image](https://github.com/Allanhenriquee/SOLID/assets/52016301/1dbfa155-6c92-4426-8bbf-d9a0a273d7e5)
