using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    /// <summary>Делегат с сигнатурой void void</summary>
    public delegate void reverseFunc();

    class Doubler
    {
        int value;
        int steps;
        int goal;

        Stack<reverseFunc> operations = new Stack<reverseFunc>();

        new Random rand = new Random();

        /// <summary>Возвращает текущее значение поля value</summary>
        public int Value { get { return this.value; } }
        /// <summary>Возвращает текущее значение поля steps</summary>
        public int Steps { get { return this.steps; } }
        /// <summary>Возвращает текущее значение поля goal</summary>
        public int Goal { get { return this.goal; } }
      
        /// <summary>Конструктор присваивает всем полям значение 0</summary>
        public Doubler()
        {
            this.value = 0;
            this.steps = 0;
            this.goal = 0;
        }

        /// <summary>Функция инкремента</summary>
        public void Increment()
        {
            this.value++;
            this.steps++;
            operations.Push(new reverseFunc(Decrement));
        }

        /// <summary>Функция увеличеняи значения вдвое</summary>
        public void Double()
        {
            this.value *= 2;
            this.steps++;
            operations.Push(new reverseFunc(DivideByTwo));
        }

        /// <summary>Функция декремента</summary>
        public void Decrement()
        {
            this.value--;
            this.steps--;
        }

        /// <summary>Функция деления на два</summary>
        public void DivideByTwo()
        {
            this.value /= 2;
            this.steps--;
        }

        /// <summary>Функция отмены действия. Проверяет стэк, если не пустой, выполняет операцию, обратную последней</summary>
        public void CheckStack()
        {
            reverseFunc reverseFunc;
            if (operations.Count != 0)
            {
                reverseFunc = operations.Pop();
                reverseFunc();
            }
            return;
        }

        /// <summary>Функция сброса текущего значения и счётчика шагов</summary>
        public void Reset()
        {
            this.value = 1;
            this.steps = 0;
            operations.Clear();
        }

        /// <summary>Функция генерации целевого значения</summary>
        public void GetGoal()
        {
            this.goal = rand.Next(2, 2049);
        }

        /// <summary>Функция проверки текущего значения с целевым</summary>
        /// <returns></returns>
        public bool CheckGoal()
        {
            return this.value == this.goal ? true : false;
        }
    }
}
