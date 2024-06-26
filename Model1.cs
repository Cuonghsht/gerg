using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace Assiment2_NET103
{

    public class Model1 : DbContext

    {

         
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Assiment2_NET103.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet <Users> Userss { get; set; }

         
        
    }
    

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
  
    public class Student
    {
        [Key]
        
        public string MaSV { get; set; }
        
        public string HoTen { get; set; }
        
        public string Email { get; set; }
        
        public string SDT { get; set; }

        public string   GioiTinh { get; set; }
        
        public string DiaChi { get; set; }
        
        public string Hinh { get; set; }
    }

    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("khoangoai")]
        
        public string MaSV { get; set; }
        public int TA { get; set; }
        public int TinHoc { get; set; }
        public int GDTC { get;set; }
        public virtual Student khoangoai { get; set; }
    }

    public class Users
    {
        [Key]
        public string Username { get; set; }
        
        public string Password { get; set; }
        public string Role { get; set; }
    
    }
}