using DomainValidation.Interfaces.Specification;
using System;
using System.Linq.Expressions;

namespace PoupaguaDDD.Domain.Specifications
{
    public class GenericSpecification<T> : ISpecification<T> where T : class
    {
        public Expression<Func<T, bool>> Expression { get; }

        public GenericSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }

        public bool IsSatisfiedBy(T entity)
        {
            return Expression.Compile().Invoke(entity);
        }
    }
}
