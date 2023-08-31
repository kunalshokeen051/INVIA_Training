public class MyClass : IDisposable
{
	private bool disposed = false;

	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			if (disposing)
			{
				// clean up
			}


			disposed = true;
		}
	}
	~MyClass()  // destructor
	{
		Dispose(false);
	}
}