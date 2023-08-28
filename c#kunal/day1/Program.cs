class Employee{

readonly int emp_id;
string name;
int department;
static int i;

public static void dob(){
    i = 10;
    Console.WriteLine(i);
}

public Employee (int emp_id, string name, int department){
    this.emp_id = emp_id;
    this.name = name;
    this.department = department;
}

    public static void Main(){
    Employee e = new Employee(1,"vaibhav",01);
    Console.WriteLine(e.emp_id);
    Console.WriteLine(e.name);
    Console.WriteLine(e.department);
    Console.WriteLine(Employee.dob);
    }
}