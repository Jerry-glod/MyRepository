using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("请输入数字A：");
                string strNumberA = Console.ReadLine();
                Console.Write("请选择运算符号（+，-，*，/）:");
                string strOperate = Console.ReadLine();
                Console.Write("请输入数字B：");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("结果是：" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("您的输入有错："+ex.Message);
            }
           
            
        }
    }
   /*
     public class Operation
     {
         private double _numberA = 0;
         private double _numberB = 0;
         public double NumberA
         {
             get
             {
                 return _numberA;
             }
             set
             {
                 _numberA = value;
             }
         }
         public double NumberB
         {
             get
             {
                 return _numberB;
             }
             set
             {
                 _numberB = value;
             }
         }
         public virtual double GetResult()
         {
             double result = 0;
             return result;
         }
     }
     class OperationAdd : Operation
     {
         public override double GetResult()
         {
             double result = 0;
             result = NumberA + NumberB;
             return result;
         }
     }
     class OperationSub : Operation
     {
         public override double GetResult()
         {
             double result = 0;
             result = NumberA - NumberB;
             return result;
         }
     }
     class OperationMul : Operation
     {
         public override double GetResult()
         {
             double result = 0;
             result = NumberA * NumberB;
             return result;
         }
     }
     class OperationDiv : Operation
     {
         public override double GetResult()
         {
             double result = 0;
             if (NumberB == 0)
                 throw new Exception("除数不能为0");
             result = NumberA / NumberB;
             return result;
         }
     }
     public class OperationFactory
     {
         public static Operation createOperate(string operate)
         {
             Operation oper = null;
             switch (operate)
             {
                 case "+":
                     {
                         oper = new OperationAdd();
                         break;
                     }
                 case "-":
                     {
                         oper = new OperationSub();
                         break;
                     }
                 case "*":
                     {
                         oper = new OperationMul();
                         break;
                     }
                 case "/":
                     {
                         oper = new OperationDiv();
                         break;
                     }
             }
             return oper;
         }
     }
    */
    
    public class Operation
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }
            return result;
        }
    }
    
}
