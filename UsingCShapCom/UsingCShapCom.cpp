// UsingCShapCom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#import "../CSharpComTest/bin/Debug/CSharpComLibTest.tlb"
using namespace CSharpComLibTest;
using namespace std;
#include <iostream>
int main()
{
	CoInitialize(NULL);
	Interface_MethodsPtr p_method(__uuidof(ImpClass));
	p_method->Init("hello","world");
	
	cin.get();

	CoUninitialize();
    return 0;
}

