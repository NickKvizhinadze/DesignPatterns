﻿using System;
using System.Collections.Generic;

namespace Proxy.Property
{
    public class Property<T> where T : new()
    {
        private T value;

        public Property() : this(Activator.CreateInstance<T>())
        {
        }

        public Property(T value)
        {
            this.value = value;
        }


        public T Value
        {
            get => value;
            set
            {
                if (Equals(this.value, value))
                    return;
                Console.WriteLine($"Assigning value to {value}");
                this.value = value;
            }
        }

        public static implicit operator T(Property<T> property)
        {
            return property.value;
        }

        public static implicit operator Property<T>(T value)
        {
            return new Property<T>(value);
        }

        public bool Equals(Property<T> other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return EqualityComparer<T>.Default.Equals(value, other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;

            return Equals((Property<T>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(value);
        }

    }
}