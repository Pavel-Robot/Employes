using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    /// <summary>
    /// Класс должность
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Название должности
        /// </summary>
        public string Name { get; set; }

        public Post(string name)
        {
            this.Name = name;
        }
    }
}
