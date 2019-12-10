using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MattyList
{
    public class MattyList<T> : IEnumerable
    {
        T[] mattyArray;
        int count = 0;
        int capacity = 4;

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {

                yield return mattyArray[i];

            }
        }
        

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

        public void Add(T input)
        { 
            
            
            
            if (Count == capacity)
            {
                capacity *= 2;
            }
            T[] tempArray = new T[capacity]; 

            for(int i = 0; i < Count; i++)
            {
                tempArray[i] = mattyArray[i];   
                               
            }
            mattyArray = tempArray;
            mattyArray[Count] = input;
            IncrementCount(1);
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
                    if (userInput.Equals(mattyArray[i + 1]))
                    {
                        DecrementCount(1);
                    }
                    else
                    {
                        tempArray[i] = mattyArray[i];
                    }
                    
                    
                }
                mattyArray = tempArray;
            
        }
        public void DecrementCount(int numberOfInputs)
        {
            for (int i = 0; i < numberOfInputs; i++)
            {
                count--;
            }
            
        }
        public string MattyToString()
        {
            string newString = "";
            for (int i = 0; i < Count; i++ )
            {
                newString += mattyArray[i].ToString() + " ";               
            }
            return newString;
        }
    }
}
