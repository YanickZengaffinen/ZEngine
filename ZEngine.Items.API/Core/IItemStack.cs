using System;
using System.Collections.Generic;
using System.Text;

namespace ZEngine.Items.Core
{
    public interface IItemStack : IItem
    {
        /// <summary>
        /// The size of this stack
        /// </summary>
        uint Size { get; }

        /// <summary>
        /// Add a certain amount to this stack
        /// </summary>
        /// <returns>How many items were added</returns>
        uint Add(uint amount);

        /// <summary>
        /// Remove a certain amount from this stack
        /// </summary>
        /// <returns>How many items were removed</returns>
        uint Remove(uint amount);

        /// <summary>
        /// The template item of this stack
        /// </summary>
        IItem Template { get; }
    }
}
