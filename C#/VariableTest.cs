﻿using System;
// => System 네임스페이스 안에 있는 클래스를 사용하겠다는 의미.

namespace VariableTest
// => 클래스 생성시 클래스에 사용할 네임스페이스 정의
// => .Net에서 제공하는 클래스와 개발자가 만든 클래스 구분 가능
{
	internal class VariableTest
	// 프로그램의 일부 => 클래스는 메소드를 1개 이상 포함해야 한다.
	{
		static void Main(string[] args)
		{
			// 변수 : 데이터를 저장하는 일정크기의 공간
			// => 코드에서 보면 값을 대입시켜 변화시킬 수 있는 요소
			// => 변수에는 단 하나의 값만 저장할 수 있다.
			// => 마지막에 저장된 값만 남는다.
			// 데이터형식 변수명;
			// 데이터형식 변수명 = 초기화 값;
			// "="은 같다의 의미가 아닌 대입(할당)의 의미이다.
			// => "="의 오른쪽에 있는 값을 왼쪽에 대입(할당, 저장)한다.

			//변수 선언 후 초기화
			int a;
			a = 10;

			// 변수 선언과 동시에 초기화
			int b = 20;

			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine("a = " + a + ", b = " + b);
			Console.WriteLine("a + b = " + (a + b));
			
			// 같은 타입의 변수라면 여러개를 한줄에 선언 가능
			int x, y, z;
			int c = 1, d = 2, e = 3;
			Console.WriteLine("c = " + c + ", d = " + d + ", e = " + e);
			// Console.WriteLine(x); => 에러 x 값이 초기화가 안되어 있다.

			// 변수명은 의미있는 단어로 만든다.
			// 여러단어를 연결해서 변수명을 작성할 때는 카멜표기법을 이용한다.
			// => 단어의 시작을 대문자로 한다. ex) variableTest
			// variable_test

		}
	}

}
