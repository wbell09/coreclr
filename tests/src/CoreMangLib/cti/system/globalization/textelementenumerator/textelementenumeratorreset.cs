using System;
using System.Globalization;
/// <summary>
///Reset
/// </summary>
public class TextElementEnumeratorReset
{
    public static int Main()
    {
        TextElementEnumeratorReset TextElementEnumeratorReset = new TextElementEnumeratorReset();
        TestLibrary.TestFramework.BeginTestCase("TextElementEnumeratorReset");
        if (TextElementEnumeratorReset.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling Reset method.");
        try
        {
            // Creates and initializes a String containing the following:
            //   - a surrogate pair (high surrogate U+D800 and low surrogate U+DC00)
            //   - a combining character sequence (the Latin small letter "a" followed by the combining grave accent)
            //   - a base character (the ligature "")
            String myString = "\uD800\uDC00\u0061\u0300\u00C6";
            // Creates and initializes a TextElementEnumerator for myString.
            TextElementEnumerator myTEE = StringInfo.GetTextElementEnumerator(myString);
            myTEE.Reset();
            myTEE.MoveNext();
            if (myTEE.ElementIndex!=0)
            {
                TestLibrary.TestFramework.LogError("001.1", " Calling Reset method ,the ElementIndex should return 0.");
                retVal = false;
               
            }
 
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
   
   
}

