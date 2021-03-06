# [Structural Patterns](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns)

## [Adapter](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/6-Adapter)
- Permite que duas classes incompatíveis trabalhem juntas envolvendo uma interface em torno de uma das classes existentes.

## [Bridge](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/7-Bridge)
- Separa uma abstração para que duas classes possam variar independentemente.

## [Composite](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/8-Composite)
- Leva um grupo de objetos para um único objeto.
- Pelo que eu entendi, acredito que sempre que tiver um objeto simples e uma 'lista' ou melhor dizendo, um objeto composto por muitos objetos de um mesmo tipo. Para facilitar a manipulacao desses objetos e sincroniza-los entre si, uma solucao viavel pode ser o padrão 'composite'.

## [Decorator](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/9-Decorator)
- Permite que o comportamento de um objeto seja estendido dinamicamente em tempo de execução.
- Pelo que eu entendi, acredito que sempre que houver necessidade de herança multipla e/ou eu quiser herdar comportamentos de outro objeto e adicionar mais features. Um caminho interessante seria usar o padrão 'decorator'.

## [Façade](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/10-Fa%C3%A7ade)
- Fornece uma interface simples para um objeto subjacente mais complexo.
- Pelo que eu entendi, acredito que uma Façade, seria uma camada de abstração de uma feature/negócio muito complexa, que não se faz necessária a sua exposição toda à todos os seus consumidores, mas sendo possível caso necessário a sua utilização em sua forma completa.
- O Façade define uma interface de nível superior que facilita o uso do subsistema.

## [Flyweight](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/11-Flyweight)
- Reduz o custo de modelos de objetos complexos.
- Quando um dado/objeto é replicado e você somente precisa da "referencia" dele, uma maneira de tratar esse caso seria usando o Pattern Flyweight.
- O Flyweight seria uma camada a mais para responder por outra que pode sofrer latência.
- Um bom exemplo seria uma api de clientes, ela demora 10 segundos para responder e temos tem que consultar o mesmo cliente, sendo que o dado dele não muda. Então se utilizado o pattern flyweight nesse caso, para guardar a primeira chamada e responder às seguintes com o mesmo dado, você conseguiria resolveria esse problema de latência e somente buscaria dados na base principal, caso esse dado não estivesse em memória.

Ex:
```	
using System.Collections.Generic;
using static System.Console;

namespace DesignPatterns_11_Flyweight_2.Exercise
{
	public class Sentence
	{
		private string[] words;
		private Dictionary<int, WordToken> _tokens = new Dictionary<int, WordToken>();

		public Sentence(string plainText)
		{
			words = plainText.Split(' ');
		}

		public WordToken this[int index]
		{
			get
			{
				WordToken wt = new WordToken();
				_tokens.Add(index, wt);
				return _tokens[index];
			}
		}

		public override string ToString()
		{
			var ws = new List<string>();
			for (var i = 0; i < words.Length; i++)
			{
				var w = words[i];
				if (_tokens.ContainsKey(i) && _tokens[i].Capitalize)
					w = w.ToUpperInvariant();
				ws.Add(w);
			}
			return string.Join(" ", ws);
		}

		public class WordToken
		{
			public bool Capitalize;
		}
	}
}
```

## [Proxy](https://github.com/matsennin/csharp-design-patterns/tree/master/Design%20Patterns/Structural%20Design%20Patterns/12-Proxy)
- O Padrão Proxy Fornece uma interface de espaço reservado para um objeto subjacente para controlar o acesso, reduzir custos ou reduzir a complexidade como também serve para adicionar mais funcionalidades a uma interface existente.
- Por exemplo, você possui uma interface "ICarro" e você também possui uma classe "Carro" que implementa essa interface que possui o método "Dirigir". Caso você queira implementar uma funcionalidade de verificação de idade para dirigir esse carro, uma maneira interessante de resolver essa questão seria, criar uma classe "CarroProxy" que teria a inteligencia de verificar a Idade do "Motorista" utilizando o próprio método "Dirigir" da interface, assim mantendo a implementação da mesma, porém adicionando mais uma funcionalidade, e depois da verificação chamar o método "Dirigir" da classe "Carro".
