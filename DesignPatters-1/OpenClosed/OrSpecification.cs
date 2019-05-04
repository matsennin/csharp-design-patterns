﻿using DesignPatters_1.Specification;
using System;

namespace DesignPatters_1.Combinator
{
    public class OrSpecification<T> : ISpecification<T>
    {
        ISpecification<T> first, second;

        public OrSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) || second.IsSatisfied(t);
        }
    }
}