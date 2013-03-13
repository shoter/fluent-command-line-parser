﻿namespace Fclp.Internals
{
    /// <summary>
    /// Contains information about a single parsed option and any value.
    /// </summary>
    public class ParsedOption
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="ParsedOption"/> class.
        /// </summary>
        /// <param name="key">The command line option key.</param>
        /// <param name="value">The value matched with the key.</param>
        public ParsedOption(string key, string value)
        {
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="ParsedOption"/> class.
        /// </summary>
        public ParsedOption()
        {
        }

        /// <summary>
        /// Gets or sets the command line option key.
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets any value matched with the key.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Determines whether two specified <see cref="ParsedOption"/> objects have the same values.
        /// </summary>
        /// <param name="other">The other <see cref="ParsedOption"/> to compare.</param>
        /// <returns>true if they are equal; otherwise false.</returns>
        protected bool Equals(ParsedOption other)
        {
            return string.Equals(Key, other.Key) && string.Equals(Value, other.Value);
        }

        /// <summary>
        /// Determines whether this <see cref="ParsedOption"/> is equal to the specified <see cref="System.Object"/>.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare.</param>
        /// <returns>true if they are equal; otherwise false.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ParsedOption) obj);
        }

        /// <summary>
        /// Returns the hashcode for this instance.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Key != null ? Key.GetHashCode() : 0)*397) ^ (Value != null ? Value.GetHashCode() : 0);
            }
        }
    }
}