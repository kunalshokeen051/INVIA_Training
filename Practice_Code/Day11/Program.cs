public interface Icounter<T>
{
	int Count { get; }
	T Get(int index);
}

public interface Ipersons<T> : Icounter<T>
{
	void Add(T item);
	void Delete(T item);
	void Modify(T item);
}

public class People<T> : Ipersons<T>
{
	private int Size;
	private T[] Persons;
	
	public People()
	{
		Size = 0;
		Persons[Size] = new T[10]; 
	}
	
	public int count {get{ return Size; }}
	void Ipersons<T>.Add(T item)
	{
		Persons[Size] = item;
		Size++;
	}

	void Ipersons<T>.Delete(T item)
	{
	
	}

	T Icounter<T>.Get(int index)
	{
	
	}

	void Ipersons<T>.Modify(T item)
	{
	
	}
	
	public int Search(T item)
	{
	   foreach (var item in collection)
	   {
		  if(item == this.item)
		  {
		  	
		  }
	   }	
	}
}
