﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace OSIRT.Helpers
{
    public class HashService
    {
        public HashService(HashAlgorithm algorithm)
        {
            HashAlgorithm = algorithm;
            Encoder = Encoding.UTF8;
        }

        public HashAlgorithm HashAlgorithm
        {
            get;
            set;
        }

        public Encoding Encoder { get; set; }

        public string ComputeHash(string input)
        {
            byte[] bytes = Encoder.GetBytes(input);
            byte[] hash = ComputeHash(bytes);
            return ToHex(hash);

        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return HashAlgorithm.TransformBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return HashAlgorithm.TransformFinalBlock(inputBuffer, inputOffset, inputCount);
        }

        public byte[] ComputeHash(byte[] buffer)
        {
            return HashAlgorithm.ComputeHash(buffer);
        }

        public byte[] ComputeHash(Stream inputStream)
        {
            return HashAlgorithm.ComputeHash(inputStream);
        }

        public string ToHex(byte[] hash)
        {
            return BitConverter.ToString(hash).Replace("-", "").ToUpper();
        }
    }
}
