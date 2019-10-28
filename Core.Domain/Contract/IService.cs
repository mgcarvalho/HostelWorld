﻿// <copyright file="IService.cs" company="Academic Lab" >
//   Copyright (c) Marcelo Carvalho. All rights reserved.
// </copyright>
// <author>Marcelo Carvalho</author>
namespace Core.Domain.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Core.Domain.Entity;
    using FluentValidation;

    /// <summary>
    /// Service contract Interfaces
    /// </summary>
    /// <typeparam name="T">Validation of an entity</typeparam>
    public interface IService<T> where T : EntityBase
    {
        /// <summary>
        /// Create a new entrance of entity
        /// </summary>
        /// <typeparam name="V">Validation of an entity</typeparam>
        /// <param name="obj">Entity to save</param>
        /// <returns>Entity saved</returns>
        T Post<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <typeparam name="V">Validation of an entity</typeparam>
        /// <param name="obj">Entity to update</param>
        /// <returns>Entity updated</returns>
        T Put<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="obj">Entity to delete</param>
        void Delete(T obj);

        /// <summary>
        /// Get an entity
        /// </summary>
        /// <param name="guid">Guid Identify</param>
        /// <returns>Returns a specific entity or null, if the conditional doesn't match</returns>
        T Get(Guid guid);

        /// <summary>
        /// Get all elements
        /// </summary>
        /// <returns>Return all saved elements of an entity</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Create a new entrance of entity
        /// </summary>
        /// <typeparam name="V">Validation of an entity</typeparam>
        /// <param name="obj">Entity to save</param>
        /// <returns>Entity saved</returns>
        Task<T> PostAsync<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <typeparam name="V">Validation of an entity</typeparam>
        /// <param name="obj">Entity to update</param>
        /// <returns>Entity updated</returns>
        Task<T> PutAsync<V>(T obj) where V : AbstractValidator<T>;

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="obj">Entity to delete</param>
        /// <returns>Entity deleted</returns>
        Task DeleteAsync(T obj);

        /// <summary>
        /// Get an entity
        /// </summary>
        /// <param name="guid">Guid Identify</param>
        /// <returns>Returns a specific entity or null, if the conditional doesn't match</returns>
        Task<T> GetAsync(Guid guid);

        /// <summary>
        /// Get all elements
        /// </summary>
        /// <returns>Return all saved elements of an entity</returns>
        Task<IEnumerable<T>> GetAllAsync();
    }
}
