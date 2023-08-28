interface Ifees<T>
{
	void SubmitFees(T fees);
}

class Managment<T> : Ifees<T>
{
	void Ifees<T>.SubmitFees(T fees)
	{
		Console.WriteLine(fees.ToString());
	}
}

class MCA
{
	public int RollNo{ get; set; }
	public string SName{ get; set; }
}
class BCA
{
	public int RollNo{ get; set; }
	public string SName{ get; set; }
}

class Accountant
{
	public static void Main()
	{
		Ifees<MCA> fee = new Managment<MCA>();
		MCA m = new();
		m.SName = "Kunal Shokeen";
		m.RollNo = 21;
		fee.SubmitFees(m);
		
		Ifees<BCA> fee1 = new Managment<BCA>();
		BCA b = new();
		b.SName = "Nilanshu";
		b.RollNo = 26;
		fee1.SubmitFees(b);
	}
}