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
			List testList;
			testList.AddToHead(5);
			testList.AddToHead(18);
			testList.AddToHead(6);
			testList.AddToHead(18);

			int goal = 18;
			int expected = 0;
			Assert::AreEqual(testList.Find(goal), expected);
		}

		TEST_METHOD(testFindNumber_NOTFOUND) 
		{
			List testList;
			testList.AddToHead(5);
			testList.AddToHead(18);
			testList.AddToHead(6);
			testList.AddToHead(18);

			int goal = 9;
			int expected = 0;
			Assert::AreEqual(testList.Find(goal), expected);
		}

		TEST_METHOD(testFindNumber_EMPTY)
		{
			List testList;

			int expected = -1;
			int goal = 10;

			Assert::AreEqual(testList.Find(goal), expected);
		}

		TEST_METHOD(testFindNumber_MULTIPLESAMENUMBER) {
			List testList;
			testList.AddToHead(5);
			testList.AddToHead(18);
			testList.AddToHead(6);
			testList.AddToHead(18);

			int goal = 18;
			int expected = 0;
			Assert::AreEqual(testList.Find(goal), expected);
		}
		//Add To Tail Tests

		TEST_METHOD(testAddToTail_LISTEMPTY)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToTail(5);
			int expected = 5;

			// Check the test conditions
			Assert::AreEqual(testList.GetTail(), expected);
		}

		TEST_METHOD(testAddToTail_LISTSIZEONE)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToHead(1);
			testList.AddToTail(5);
			int expected = 5;

			// Check the test conditions
			Assert::AreEqual(testList.GetTail(), expected);
		}

		TEST_METHOD(testAddToHEAD_Empty)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToHead(5);
			int expected = 5;

			// Check the test conditions
			Assert::AreEqual(testList.GetHead(), expected);
		}

		TEST_METHOD(testAddToHEAD_WithData)
		{
			// Create the list
			List testList;

			// Create the test conditions
			testList.AddToHead(5);
			testList.AddToHead(10);
			int expected = 10;

			// Check the test conditions
			Assert::AreEqual(testList.GetHead(), expected);
		}
	};
}
