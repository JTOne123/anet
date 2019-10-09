﻿using System;

namespace Anet.Data.Entity
{
    public interface IEntity<TKey> : ITable
        where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }

        void SetNewId();
    }

    public interface IEntity : IEntity<long>
    {
    }
}
