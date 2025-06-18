﻿using DesignPatterns.Behavioral.Interpreter.Interfaces;

namespace DesignPatterns.Behavioral.Interpreter.Expressions;

public class NumberExpression : IExpression
{
    private readonly int _number;

    public NumberExpression(int number) => _number = number;

    public int Interpret() => _number;
}
