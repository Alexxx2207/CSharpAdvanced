using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {
        private T left;
        private T right;

        /// <summary>
        /// A controctor making the Equality Scale 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }
        /// <summary>
        /// Compares the left and the right side of the Equality Scale
        /// </summary>
        /// <returns></returns>
        public bool AreEqual()
        {
            return left.Equals(right);
        }
    }
}
