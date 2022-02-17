#include "pch.h"
#include "CppUnitTest.h"
#include "../SE3330HW1/List.h"
#include "../SE3330HW1/List.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace SE3330HW1Tests
{
	TEST_CLASS(SE3330HW1Tests)
	{
	public:
		
		TEST_METHOD(testIsEmpty_TRUE)
		{
			List testList;
			Assert::IsTrue(testList.IsEmpty());
		}
	};
}
