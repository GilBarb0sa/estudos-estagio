﻿using System;

namespace Generics.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        protected Entity() => Id = Guid.NewGuid();
        public abstract override string ToString();
        public abstract override bool Equals(object obj);
    }
}