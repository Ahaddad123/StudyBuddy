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
			// Create the list
			List testList;

			// Check the test conditions
			Assert::IsTrue(testList.IsEmpty());
		}

		TEST_METHOD(testIsEmpty_FAlSE)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToHead(5);

			// Check the test conditions
			Assert::IsFalse(testList.IsEmpty());
		}

		TEST_METHOD(testGetLength_ZERO)
		{
			// Create the list
			List testList;

			// Create the test conditions
			int expected = 0;

			// Check the test conditions
			Assert::AreEqual(testList.Length(), expected);
		}

		TEST_METHOD(testGetLength_NONZERO)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToHead(5);
			int expected = 1;

			// Check the test conditions
			Assert::AreEqual(testList.Length(), expected);
		}

		TEST_METHOD(testFindNumber_FOUND)
		{

		}

		TEST_METHOD(testFindNumber_NOTFOUND) 
		{
		}
	};
}
