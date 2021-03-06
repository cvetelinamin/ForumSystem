namespace ForumSystem.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICategoriesService
    {
        IEnumerable<T> GetAll<T>(int? count = null);
    }
}
