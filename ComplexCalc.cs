using System;

namespace ds168
{
    
    public class ComplexCalc
    {
        private int Real1,Real2,Imaginary1,Imaginary2=0;
        public ComplexCalc(int a,int b,int c,int d){
        setReal1(a);
        setImaginary1(b);
        setReal2(c);
        setImaginary2(d);
        }
        //setters
        public void setReal1(int a){
            Real1=a;
        }
        public void setImaginary1(int b){
            Imaginary1=b;
        }
        public void setReal2(int c){
            Real2=c;
        }
        public void setImaginary2(int d){
            Imaginary2=d;
        }
        
        //getters
        public int getReal1(){
            return Real1;
        }
        public int getImaginary1(){
            return Imaginary1;
        }
        public int getReal2(){
            return Real2;
        }
        public int getImaginary2(){
            return Imaginary2;
        }
        
        //Addition
        public int realAddition(){
            return getReal1()+getReal2();
        } 

        public int imgAddition(){
            return  getImaginary1()+getImaginary2();
        }
        public int realSubtraction(){
            return getReal1()-getReal2();
        } 
        public int imgSubtraction(){
                return  getImaginary1()-getImaginary2();
        }
        public int realMultiplication(){
            return getReal1()*getReal2()-getImaginary1()*getImaginary2();
        } 
        public int imgMultiplication(){
            return  getImaginary1()*getReal2()+getReal1()*getImaginary2();
        }
        public int realDivision(){
            return getReal1()*getReal2()+getImaginary1()*getImaginary2()/(getReal2()*getReal2()+getImaginary2()*getImaginary2());
        } 
        public int imgDivision(){
            return  getImaginary1()*getReal2()-getReal1()*getImaginary2()/(getReal2()*getReal2()+getImaginary2()*getImaginary2());
        }

            
    }
}
