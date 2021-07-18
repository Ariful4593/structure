using System;
namespace structure{
	public class Test{
		public static void Main(string[] args){
			StudentInfo e1 = new StudentInfo(10, 75);
			
			Console.WriteLine(e1.mark);
		}
	}	
}

struct StudentInfo{
	public int id;
	public int mark;
	public StudentInfo(int x, int y){
		this.id = x;
		this.mark = y;
	}
}
