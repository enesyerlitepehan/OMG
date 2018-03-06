using System.ComponentModel.DataAnnotations;
namespace MYARCH.CORE
{
    public abstract class Base
    {
        [Key] //Primarykey olduğunu belli eder
        public int Id { get; set; }
    }
}
