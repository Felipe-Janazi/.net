using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                // Estrutura de controle
                {"Estrutura If - Estruturas de controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estruturas de controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de controle", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de controle", UsandoBreak.Executar },
                {"Usando Continuar - Estruturas de controle", UsandoContinue.Executar },

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos com retorno - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos", GetSet.Executar },
                {"Propos - Classes e Métodos", Props.Executar },
                {"Readonly - Classes e Métodos", Readonly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Métodos", StructVSClasse.Executar },
                {"Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetro por Padrão - Classes e Métodos", ParametroPadrao.Executar },

                // Coleções
                {"Array - Classes e Métodos", UsandoArray.Executar },
                {"List - Classes e Métodos", ColecoesList.Executar },
                {"ArrayList - Classes e Métodos", ColecoesArrayList.Executar },
                {"Set - Classes e Métodos", ColecoesSet.Executar },
                {"Queue - Classes e Métodos", ColecoesQueue.Executar },
                {"Igualdade - Classes e Métodos", Igualdade.Executar },
                {"Stack - Classes e Métodos", ColecaoStack.Executar },
                {"Dictionary - Classes e Métodos", ColecoesDictionary.Executar },

                // OO
                {"Herança - Orientação a Objetos", Heranca.Executar },
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar },
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}