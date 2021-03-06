using System;
/// <summary>
///Module
/// </summary>

public class AttributeTargetsModule
{
    public static int Main()
    {
        AttributeTargetsModule AttributeTargetsModule = new AttributeTargetsModule();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsModule");
        if (AttributeTargetsModule.RunTests())
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
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Module value is 0x0002. ");
        try
        {
            int expectValue = 0x0002;
            if ((int)AttributeTargets.Module != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Module should return 0x0002.");
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

