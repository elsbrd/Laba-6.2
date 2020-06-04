using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab6._2
{
    public class SortClient<T>
    {
                List<T> arrayAggrement;//одобрить кредит
                List<T> arrayDisagrement;
        
                public SortClient(List<T> array) //List<T> array
                {
                    arrayAggrement = new List<T>();
                    arrayDisagrement = new List<T>();
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i].ToString().Split(' ')[2].Equals("True") )
                        {
                            arrayAggrement.Add(array[i]);
                        }
                        else
                        {
                            arrayDisagrement.Add(array[i]);
                        }
                    }
        
                }
                public List<T> ArrayAggrement
                {
                    get {return arrayAggrement; }
                    set {arrayAggrement = value; }
                }
        
                public List<T> ArrayDisaggrement
                {
                    get { return arrayDisagrement; }
                    set { arrayDisagrement = value; }
                }

    }
}