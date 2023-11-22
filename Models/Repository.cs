using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {Id=1,Title=".Net 7",Description="Ücretsiz",Image="1.jpg"},
                new Course() {Id=2,Title="JavaScript",Description="Ücretsiz",Image="2.jpg"},
                new Course() {Id=3,Title="Django",Description="Ücretsiz",Image="3.jpg"}
            };
        }
        public static List<Course> Courses{
            get{
                return _courses;
            }
        }

        public static Course? GetById(int id)
        {
            var cr = _courses.FirstOrDefault(c => c.Id == id);
            return cr;
        }
    }
}