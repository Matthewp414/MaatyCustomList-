using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattyList
{
    public class MattyList<T>
    {
        T[] mattyArray;
        int count = 0;
        int capacity = 4;

        public T this[int i]
        {
            get 
            {
                return mattyArray[i];
            }
            set
            {
                mattyArray[i] = value;
            }
        }
        
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        
       

        public MattyList()
        {
            
            mattyArray = new T[capacity];
            count = 0;
        }
        
           
        public void CountChecker(MattyList<T> list)
        {
            
        }

        public void MattyAdd(T input)
        { 
            T[] tempArray = new T[capacity];
            IncrementCount(1);
            if (Count >= capacity)
            {
                capacity *= 2;
            } 
            for(int i = 0; i < Count; i++)
            {
                tempArray[i] = mattyArray[i];                   
            }
            mattyArray = tempArray;
            mattyArray[Count] = input;
        }

        public void IncrementCount(int numberOfInputs)
        {
            if(numberOfInputs < 0)
            {
                throw new ArgumentOutOfRangeException("You cant do that ");

            }
            for(int i = 0; i < numberOfInputs; i++)
            {
                count++;
            }  
            
        }

        public void MattyRemove(T userInput )
        {
            T[] tempArray = new T[capacity];

            int i = 0;         
                for(i=0; i < Count; i++)
                {
                    if (userInput.Equals(mattyArray[i]))
                    {

                    }
                    else
                    {
                        tempArray[i] = mattyArray[i];
                    }
                    mattyArray = tempArray;
                }
            
            DecrementCount(1);
        }
        public void DecrementCount(int numberOfInputs)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                count--;
            }
            
        }
        public void MattyToString()
        {
            StringBuilder sb;
            for (int i = 0; i < Count; i++ )
            {
                
                ;
            }
        }
    }
}
