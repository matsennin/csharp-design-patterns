# [The SOLID Design Principles](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID)

## [Single Responsibility Principle (SRP):](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID/SingleResponsibilityPrinciple)
- Uma classe ou método não deve ter mais de uma responsabilidade.

## [Open Closed Principle:](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID/OpenClosedPrinciple)
- Um objeto deve estar fechado para modificações como por exemplo, adicionar mais funções/métodos na mesma classe causando assim uma modificação do objeto (classe).
- Porém ele deve estar aberto para extensões, como por exemplo estar habilitado para aceitar novas funções/método de filtro no sistema porém em suas classes especificas.

## [Liskov Substitution Principle:](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID/LiskovSubstitutionPrinciple)
- Classes que serão herdadas devem ser criadas de uma maneira que seja possível fazer uma reescrita de seus métodos e propriedades sem impactar o comportamento do objeto PAI.
- Basicamente o Pai pelo Filho e o Filho pelo Pai.

Liskov Ex: 
```
public class Parent
{
	public virtual void X()
	{
		x = y + y;
	}
}

public class Child : Parent
{	
	public override void X()
	{
		x = (y + y) * 2;
	}
}
```

## [Interface Segregation Principle:](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID/InterfaceSegregationPrinciple)
- As interfaces que especificam as funcionalidades de seus implementadores devem ser criadas de forma granular, 
para não obrigar os implementadores a criarem especificações de funções que não façam parte de seu escopo.

## [Dependency Inversion Principle:](https://github.com/matsennin/csharp-design-patterns/tree/master/SOLID/DependencyInversionPrinciple)
- Dada uma propriedade/field que desejamos que seja privada, porém acessivel, devemos implementar um acessor(interface/método) para somente acessar seu valor.
