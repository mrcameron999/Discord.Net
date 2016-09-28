﻿using System;

namespace Discord.Rest
{
    public abstract class RestEntity<T> : IEntity<T>
        where T : IEquatable<T>
    {
        public DiscordClient Discord { get; }
        public T Id { get; }

        internal RestEntity(DiscordClient discord, T id)
        {
            Discord = discord;
            Id = id;
        }

        IDiscordClient IEntity<T>.Discord => Discord;
    }
}
