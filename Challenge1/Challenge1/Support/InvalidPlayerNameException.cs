﻿using System;

namespace Challenge1
{
    public class InvalidPlayerNameException : Exception
    {
        public InvalidPlayerNameException()
        {
        }

        public InvalidPlayerNameException(string message) : base(message)
        {
        }

        public InvalidPlayerNameException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}