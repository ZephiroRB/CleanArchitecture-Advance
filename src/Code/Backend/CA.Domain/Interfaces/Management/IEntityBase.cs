﻿namespace CA.Domain.Interfaces.Management
{
    public interface IEntityBase<TKey> : IAddEntity<TKey>, IUpdateEntity<TKey>, IDeleteEntity<TKey> { }
}
