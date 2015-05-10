csc /target:library /out:Calc.dll SimpleCalc.cs ComplexCalc.cs
csc /target:exe /reference:Calc.dll Calc.cs
Calc.exe