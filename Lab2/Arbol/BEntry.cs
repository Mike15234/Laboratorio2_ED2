﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Arbol
{
    public class Entry<TKey, T> : IEquatable<Entry<TKey, T>>, IEntry<TKey, T>
    {
        public TKey LLave { get; set; }

        public T Apuntador { get; set; }

        /// <summary>
        /// Comparador de llaves y apuntadores
        /// </summary>
        /// <param name="other">Entrada</param>
        /// <returns>Valor booleano</returns>
        public bool Equals(Entry<TKey, T> other)
        {
            return this.LLave.Equals(other.LLave) && this.Apuntador.Equals(other.Apuntador);
        }

    }
    public interface IEntry<TKey, T>
    {
        bool Equals(Entry<TKey, T> other);
    }
}
