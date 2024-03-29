﻿using System;
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
        public static MattyList<T> operator +(MattyList<T> b, MattyList<T> c)
        {
            MattyList<T> newList = new MattyList<T>();
            for (int i = 0; i < b.Count; i++ )
            {
                newList.Add(b[i]);
            }
            for (int i = 0; i < c.Count; i++)
            {
                newList.Add(c[i]);
            }
            return newList;
        }
        public static MattyList<T> operator -(MattyList<T> b, MattyList<T> c)
        {
            MattyList<T> newList = new MattyList<T>();

            for (int i = 0; i < b.Count; i++)
            {
                b.MattyRemove(c[i]);
            }
            return b;

            
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
                    if (userInput.Equals(mattyArray[i]))
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

        public void Zip(MattyList<T> userInput)
        {
            MattyList<T> tempArray = new MattyList<T>();
            int x = userInput.count;
            int y = Count;

            for (int i = 0; i < y || i < x ; i++)
            {
                if (count == 0)
                {
                    tempArray.Add(userInput[i]);
                    userInput.count--;


                }
                else if(userInput.Count == 0)
                {
                    tempArray.Add(mattyArray[i]);
                    DecrementCount(1);

                }
                else
                {
                    tempArray.Add(userInput[i]);
                    tempArray.Add(mattyArray[i]);
                    userInput.count--;
                    DecrementCount(1);
                }
                
                
            }
            
            mattyArray = new T[tempArray.count]; 
            for (int i = 0; i < tempArray.Count; i++)
            {   
                count = tempArray.Count; 
                if (Count >= Capacity)
                {
                capacity *= 2;
                }
                 mattyArray[i] = tempArray[i];
            }
            
            
           
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
