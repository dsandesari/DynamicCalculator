using System;

namespace ds168
{
	
	public class SimpleCalc
	{
		private int num1,num2=0;
		public SimpleCalc(int a,int b){
	    setNum1(a);
		setNum2(b);
		}
		//setters
		public void setNum1(int a){
			num1=a;
		}
		public void setNum2(int b){
			num2=b;
		}
		
		//getters
		public int getNum1(){
			return num1;
		}
		public int getNum2(){
			return num2;
		}
		
		//Addition
        public int Addition(){
        	return getNum1()+getNum2();
        } 

       //Subtraction
        public int Subtraction(){
        	return getNum1()-getNum2();
        } 
        //Multiplication
         public int Multiplication(){
        	return getNum1()*getNum2();
        } 
       //Division
        public int Division(){
        	return getNum1()/getNum2();
        } 
       

            
	}
}
