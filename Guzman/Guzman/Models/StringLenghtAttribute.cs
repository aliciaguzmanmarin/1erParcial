using System;

namespace Guzman.Models
{
    internal class StringLenghtAttribute : Attribute
    {
        public int MinimunLenght { get; set; }
        public object ErrorMessage { get; set; }
    }
}