using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDeémpendencyInjectionType
{
    public interface ITransient
    {

    }
    public interface IScoped
    {

    }
    public interface ISingleton
    {

    }
    public class MyObject : ITransient, IScoped, ISingleton
    {
        public readonly int Value;

        public MyObject()
        {
            Value = new Random().Next(100000);
        }
    }
}
