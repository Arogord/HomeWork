
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HomeWork11_2
{
    public class MyDictionary<TKey, TValue> 
    {
        //int[] hashtable;
        MyStructDictionary<TKey, TValue>[] entry;
        int hash;
        
        public MyDictionary()
        {
            //hashtable = new int[8];
            entry = new MyStructDictionary<TKey, TValue>[8];

        }
        public void Add(TKey key, TValue value)
        {
            hash = key.GetHashCode()% entry.Length;
            if(!entry[hash].placeNotFree)
            {
                entry[hash].key = key;
                entry[hash].value = value;
                entry[hash].placeNotFree = true;
                Console.WriteLine($"Key: {key}, Value: {value} is added");
            }
            else
            {
                Console.WriteLine("Error this key is already in the dictionary!");
            }

        }
        public void Remove(TKey key)
        {
            hash = key.GetHashCode() % entry.Length;
            if (entry[hash].placeNotFree)
            {
                Console.WriteLine($"Keys Value pairs is removed: {key} - {entry[hash].value}");
                entry[hash].key = default;
                entry[hash].value = default;
                entry[hash].placeNotFree = default;
                
            }
            else
            {
                Console.WriteLine($"Key: {key} - is not found");
            }

        }
        public TValue GetValue(TKey key)  //can return null!
        {
            hash = key.GetHashCode() % entry.Length;
            if (entry[hash].placeNotFree)
            {
                return entry[hash].value;
            }
            else throw new ArgumentException();
            
            
        }
        public void PrintAllKeys()
        {
            Console.WriteLine("The dictionary contains the following keys:");
            for(int i = 0; i < entry.Length; i++)
            {
                if (entry[i].placeNotFree)
                {
                    Console.WriteLine(entry[i].key);
                }
            }

        }

    }
}
