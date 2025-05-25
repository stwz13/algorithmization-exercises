
using System;

namespace ConsoleApp1
{
    class array<T>
    {
        public uint count_of_elements { get; protected set; }
        T[] my_array;
        
        public array()
        {
            count_of_elements = 0;
            my_array = new T[count_of_elements];
            
        }


        public void Append(T new_element)
        {
            T[] new_array = new T[count_of_elements + 1];

            for (int i = 0; i < count_of_elements; i++)
            {
                new_array[i] = my_array[i];
            }


            new_array[count_of_elements] = new_element;

            my_array = new_array;

            count_of_elements++;

        }

        public void Delete(uint index)
        {
            if (index > count_of_elements)
            {
                Console.WriteLine("Выход за пределы массива");
                return;
            }
            T[] new_array = new T[count_of_elements - 1];

            for (int i =0, j = 0; i < count_of_elements - 1; i++, j++)
            {
                if (i == index) j++;
                new_array[i] = my_array[j];   
            }
            my_array = new_array;
            count_of_elements--;
        }

        public T Get_element(uint index)
        {

            if (index < count_of_elements) Console.WriteLine("Индекс вне границ массива");
            T search_element = default;
            for (int i = 0; i < count_of_elements; i++)
            {
                if (i == index) search_element = my_array[i];
          
            }

            return search_element;
        }
        public void Print()
        {
            foreach (T element in my_array) Console.WriteLine(element);
        }
    }

    class Test
    {
        static void Main()
        {
            array<int> test_array = new array<int>();

            test_array.Append(1);
            test_array.Append(2);
            test_array.Append(3);
            test_array.Delete(2);
            test_array.Get_element(0);
            
        }
    }
}
